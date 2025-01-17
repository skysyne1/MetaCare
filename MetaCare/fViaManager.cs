﻿using MetaCare.Containers;
using MetaCare.Contants;
using MetaCare.Dtos;
using MetaCare.Handlers;
using MetaCare.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaCare
{
    public partial class fViaManager : Form
    {
        public fViaManager()
        {
            InitializeComponent();
            Onload();
        }

        private void Onload()
        {
            cbbTypeLogin.SelectedIndex = 0;
        }

        private void ChoseRowInDatagrid(string modeChose)
        {
            if (!(modeChose == "ToggleCheck"))
            {
                if (!(modeChose == "SelectHighline"))
                {
                    if (!(modeChose == "UnAll"))
                    {
                        if (modeChose == "All")
                        {
                            for (int i = 0; i < this.dgv.RowCount; i++)
                            {
                                DatagridviewHelper.SetStatusDataGridView(dgv, i, "cChose", true);
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < this.dgv.RowCount; j++)
                        {
                            DatagridviewHelper.SetStatusDataGridView(dgv, j, "cChose", false);
                        }
                    }
                }
                else
                {
                    DataGridViewSelectedRowCollection selectedRows = this.dgv.SelectedRows;
                    for (int k = 0; k < selectedRows.Count; k++)
                    {
                        DatagridviewHelper.SetStatusDataGridView(dgv, selectedRows[k].Index, "cChose", true);
                    }
                }
            }
            else
            {
                for (int l = 0; l < this.dgv.SelectedRows.Count; l++)
                {
                    int index = this.dgv.SelectedRows[l].Index;
                    DatagridviewHelper.SetStatusDataGridView(dgv, index, "cChose", !Convert.ToBoolean(DatagridviewHelper.GetStatusDataGridView(dgv, index, "cChose")));
                }
            }
        }

        private void chọnBôiĐenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoseRowInDatagrid("SelectHighline");
        }

        private void chọnTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv.CurrentCell = dgv.CurrentRow.Cells[1];
            ChoseRowInDatagrid("All");
        }

        private void bỏChọnTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoseRowInDatagrid("UnAll");
        }

        private void dánTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            var clipboard = Clipboard.GetText();

            if (string.IsNullOrEmpty(clipboard))
            {
                MessageBox.Show("Không có dữ liệu trong clipboard", "Thông báo");
                return;
            }

            Task.Run(() =>
            {
                try
                {
                    var datas = clipboard
                        .Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    var rowsToAdd = new List<DataGridViewRow>();

                    foreach (var data in datas)
                    {
                        if (!string.IsNullOrEmpty(data))
                        {
                            var dataRaw = data.Split('|');
                            if (dataRaw.Length >= 3)
                            {
                                var row = new DataGridViewRow();
                                row.CreateCells(dgv);

                                row.Cells[1].Value = rowsToAdd.Count + 1; // Dùng danh sách để xác định thứ tự
                                row.Cells[2].Value = dataRaw[0];
                                row.Cells[3].Value = dataRaw[1];
                                row.Cells[4].Value = dataRaw[2].Length == 32 ? dataRaw[2] : "";
                                row.Cells[7].Value = dataRaw.FirstOrDefault(x => x.Contains("c_user"));
                                row.Cells[8].Value = dataRaw.FirstOrDefault(x => x.Contains("EAA"));

                                rowsToAdd.Add(row);
                            }
                        }
                    }

                    // Thêm các hàng vào DataGridView trên UI thread
                    dgv.Invoke((Action)(() =>
                    {
                        foreach (var row in rowsToAdd)
                        {
                            dgv.Rows.Add(row);
                        }
                    }));
                }
                catch
                {
                    MessageBox.Show("Lỗi dán thông tin via. Vui lòng thử lại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

        }

        private async void cookieVàTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int typeLogin = cbbTypeLogin.SelectedIndex;
            int maxThread = (int)numMaxThread.Value;

            if (maxThread == 0)
            {
                MessageBox.Show("Số luồng không được bằng 0", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rows = GetCheckedRows();
            if (rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để chạy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var tasks = new List<Task>();
            var semaphore = new SemaphoreSlim(maxThread, maxThread);

            foreach (var row in rows)
            {
                await semaphore.WaitAsync();
                tasks.Add(HandleRowAsync(row, typeLogin, semaphore));
            }

            await Task.WhenAll(tasks);
        }

        private async Task HandleRowAsync(DataGridViewRow row, int typeLogin, SemaphoreSlim semaphore)
        {
            try
            {
                UpdateRowStatus(row, "Tiến hành đăng nhập...");
                var accountDto = CreateAccountDto(row);

                if (typeLogin == 0 && string.IsNullOrEmpty(accountDto.Cookies))
                {
                    UpdateRowStatus(row, "Cookie rỗng!");
                    return;
                }

                ApiClient apiClient = null;
                if (typeLogin == 0 && !string.IsNullOrEmpty(accountDto.Cookies))
                {
                    apiClient = new ApiClient(accountDto, true, FacebookContant.UserAgent);
                }
                else
                {
                    apiClient = new ApiClient(accountDto, false, FacebookContant.UserAgent);
                }

                var facebookHandlerDto = new FacebookHandlerDto
                {
                    Account = accountDto,
                    TypeLogin = typeLogin,
                    ApiClient = apiClient,
                };


                var facebookHandler = new FacebookHandler(facebookHandlerDto);
                var status = await facebookHandler.LoginFacebook();

                UpdateRowStatus(row, status.ToString());

                if (status == FacebookHandler.Status.Success)
                {
                    UpdateRowStatus(row, "Bắt đầu get token");

                    var (cookies, token) = await facebookHandler.GetTokenAsync();
                    row.Cells[7].Value = cookies;
                    row.Cells[8].Value = token;

                    if (!string.IsNullOrEmpty(cookies) && !string.IsNullOrEmpty(token))
                    {
                        FacebookContainer.Instance.FacebookHandlers.Add(facebookHandlerDto);
                    }

                    UpdateRowStatus(row, "Get token xong");
                }
                else
                {
                    UpdateRowStatus(row, $"Đăng nhập thất bại=> {status}");
                }
            }
            catch
            {
                UpdateRowStatus(row, "Lỗi đăng nhập");
            }
            finally
            {
                semaphore.Release();
            }
        }

        private void UpdateRowStatus(DataGridViewRow row, string status)
        {
            row.Cells["cStatus"].Value = status;
        }

        private List<DataGridViewRow> GetCheckedRows()
        {
            return dgv.Rows.Cast<DataGridViewRow>()
                .Where(row => row.Cells[0].Value != null && Convert.ToBoolean(row.Cells[0].Value))
                .ToList();
        }

        private AccountDto CreateAccountDto(DataGridViewRow row)
        {
            return new AccountDto
            {
                Uid = row.Cells[2].Value.ToString(),
                Password = row.Cells[3].Value.ToString(),
                Key2Fa = row.Cells[4].Value?.ToString(),
                Cookies = row.Cells[7].Value?.ToString(),
                TokenEAAG = row.Cells[8].Value?.ToString()
            };
        }

        private void quảnLýQuảngCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int typeLogin = (int)cbbTypeLogin.SelectedIndex;
            var rows = GetCheckedRows();
            foreach (DataGridViewRow row in rows)
            {
                var accountDto = CreateAccountDto(row);
                var exists = FacebookContainer.Instance.FacebookHandlers.FirstOrDefault(x => x.Account == accountDto);
                if (exists != null)
                {
                    var fAdManager = new Form1(exists)
                    {
                        Text = accountDto.Uid + "-" + accountDto.Name
                    };
                    fAdManager.Show();
                }
                else
                {
                    var fAdManager = new Form1(new FacebookHandlerDto
                    {
                        Account = accountDto,
                        TypeLogin = typeLogin,
                    })
                    {
                        Text = accountDto.Uid + "-" + accountDto.Name
                    };
                    fAdManager.Show();
                }
            }
        }
    }
}
