﻿using MetaCare.Containers;
using MetaCare.Contants;
using MetaCare.Dtos;
using MetaCare.Handlers;
using MetaCare.Helpers;
using MetaCare.Proxy.Managers;
using MetaCare.Proxy.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaCare
{
    public partial class fViaManager : Form
    {
        private readonly List<ProxyService> _proxyServices;
        private ProxyManager _proxyManager;
        private const int DEFAULT_DELAY = 1000; // ms

        public fViaManager()
        {
            InitializeComponent();
            _proxyServices = new List<ProxyService>();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            cbbTypeLogin.SelectedIndex = 0;
            cbbTypeProxy.SelectedIndex = 0;
            cbbFeature.SelectedIndex = 0;
            cbbTypeName.SelectedIndex = 0;
        }

        private void ChoseRowInDatagrid(SelectionMode mode)
        {
            switch (mode)
            {
                case SelectionMode.All:
                    SetAllRowsSelection(true);
                    break;
                case SelectionMode.None:
                    SetAllRowsSelection(false);
                    break;
                case SelectionMode.Selected:
                    SetSelectedRowsSelection(true);
                    break;
                case SelectionMode.Toggle:
                    ToggleSelectedRowsSelection();
                    break;
            }
        }

        private void SetAllRowsSelection(bool selected)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                DatagridviewHelper.SetStatusDataGridView(dgv, i, "cChose", selected);
            }
        }

        private void SetSelectedRowsSelection(bool selected)
        {
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                DatagridviewHelper.SetStatusDataGridView(dgv, row.Index, "cChose", selected);
            }
        }

        private void ToggleSelectedRowsSelection()
        {
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                int index = row.Index;
                bool currentStatus = Convert.ToBoolean(DatagridviewHelper.GetStatusDataGridView(dgv, index, "cChose"));
                DatagridviewHelper.SetStatusDataGridView(dgv, index, "cChose", !currentStatus);
            }
        }

        private void InitializeProxyServices(int typeProxy, int limitThreadUse)
        {
            if (typeProxy == 0) return;

            var proxyLines = File.ReadAllLines("Data//Proxy.txt");
            foreach (var line in proxyLines)
            {
                var proxyParts = line.Split('|');
                var proxyService = CreateProxyService(proxyParts, typeProxy, limitThreadUse);
                
                if (proxyService != null && proxyService.ResetProxy())
                {
                    _proxyServices.Add(proxyService);
                }
            }

            _proxyManager = new ProxyManager(_proxyServices);
        }

        private ProxyService CreateProxyService(string[] proxyParts, int typeProxy, int limitThreadUse)
        {
            if (proxyParts.Length > 1)
            {
                return new ProxyService(proxyParts[0], proxyParts[1], typeProxy, limitThreadUse);
            }
            else if (proxyParts.Length == 1 && (typeProxy == 1 || typeProxy == 2))
            {
                return new ProxyService(proxyParts[0], "", typeProxy, limitThreadUse);
            }
            return null;
        }

        private void chọnBôiĐenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoseRowInDatagrid(SelectionMode.Selected);
        }

        private void chọnTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv.CurrentCell = dgv.CurrentRow.Cells[1];
            ChoseRowInDatagrid(SelectionMode.All);
        }

        private void bỏChọnTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoseRowInDatagrid(SelectionMode.None);
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
                                row.Cells[4].Value = dataRaw[2].Length >= 32 ? dataRaw[2] : "";
                                row.Cells[7].Value = dataRaw.FirstOrDefault(x => x.Contains("c_user"));
                                row.Cells[8].Value = dataRaw.FirstOrDefault(x => x.Contains("EAA"));

                                rowsToAdd.Add(row);
                            }
                            else if (dataRaw.Length == 1 && dataRaw[0].Contains("c_user"))
                            {
                                var uid = Regex.Match(dataRaw[0], "c_user=(.*?);").Groups[1].Value;
                                var row = new DataGridViewRow();
                                row.CreateCells(dgv);

                                row.Cells[1].Value = rowsToAdd.Count + 1; // Dùng danh sách để xác định thứ tự
                                row.Cells[2].Value = uid;
                                row.Cells[7].Value = dataRaw[0];
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
            int typeProxy = cbbTypeProxy.SelectedIndex;
            int limitThreadUse = (int)numLimitThreadUse.Value;
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

            InitializeProxyServices(typeProxy, limitThreadUse);

            if (typeProxy != 0)
            {
                maxThread = Math.Min(maxThread, _proxyServices.Count * limitThreadUse);
            }

            var tasks = new List<Task>();
            var semaphore = new SemaphoreSlim(maxThread, maxThread);

            foreach (var row in rows)
            {
                await semaphore.WaitAsync();
                tasks.Add(Task.Run(async () =>
                {
                    string proxy = string.Empty;
                    ProxyService proxyService = null;
                    if (typeProxy != 0)
                    {
                        while (proxyService == null)
                        {
                            proxyService = _proxyManager.GetAvailableProxy();
                            if (proxyService == null)
                            {
                                // Nếu không có proxy khả dụng, chờ 1 giây trước khi thử lại
                                await Task.Delay(1000);
                            }
                        }

                        proxy = proxyService.Proxy;
                    }

                    try
                    {
                        await HandleRowAsync(row, typeLogin, proxy);
                    }
                    catch
                    {
                        UpdateRowStatus(row, "Lỗi!");
                    }
                    finally { semaphore.Release(); }
                }));
            }

            await Task.WhenAll(tasks);
        }

        private async Task HandleRowAsync(DataGridViewRow row, int typeLogin, string proxy)
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
                    apiClient = new ApiClient(accountDto, true, FacebookContant.UserAgent, proxy);
                }
                else
                {
                    apiClient = new ApiClient(accountDto, false, FacebookContant.UserAgent, proxy);
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

                    var (cookies, token, dtsgToken) = await facebookHandler.GetTokenAsync();
                    var name = await facebookHandler.GetName();
                    row.Cells[7].Value = cookies;
                    row.Cells[8].Value = token;

                    facebookHandlerDto.Account.TokenEAAG = token;
                    facebookHandlerDto.Account.Cookies = cookies;
                    facebookHandlerDto.Account.DTSGToken = dtsgToken;
                    facebookHandlerDto.Account.Name = name;

                    if (!string.IsNullOrEmpty(cookies) && !string.IsNullOrEmpty(token))
                    {
                        if (!FacebookContainer.Instance.FacebookHandlers.Contains(facebookHandlerDto))
                        {
                            FacebookContainer.Instance.FacebookHandlers.Add(facebookHandlerDto);
                        }
                    }

                    UpdateRowStatus(row, "Get token xong");
                }
                else
                {
                    UpdateRowStatus(row, $"Đăng nhập thất bại=> {status.ToString()}");
                }
            }
            catch
            {
                UpdateRowStatus(row, "Lỗi đăng nhập");
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
                Password = row.Cells[3].Value?.ToString(),
                Key2Fa = row.Cells[4].Value?.ToString(),
                Cookies = row.Cells[7].Value?.ToString(),
                TokenEAAG = row.Cells[8].Value?.ToString()
            };
        }

        private void quảnLýQuảngCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int typeLogin = cbbTypeLogin.SelectedIndex;
            var rows = GetCheckedRows();
            foreach (DataGridViewRow row in rows)
            {
                var accountDto = CreateAccountDto(row);
                var exists = FacebookContainer.Instance.FacebookHandlers.FirstOrDefault(x => x.Account.Uid == accountDto.Uid);
                if (exists != null)
                {
                    var fAdManager = new Form1(exists)
                    {
                        Text = exists.Account.Uid + "-" + exists.Account.Name
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Data//Proxy.txt");
        }

        private void nhậpTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() != DialogResult.OK || string.IsNullOrEmpty(openFileDialog.FileName))
                    return;

                dgv.Rows.Clear();
                var accounts = File.ReadAllLines(openFileDialog.FileName)
                                  .Where(line => !string.IsNullOrEmpty(line))
                                  .Select(line => line.Split('|'))
                                  .Where(dataRaw => dataRaw.Length >= 3)
                                  .ToList();

                var rowsToAdd = accounts.Select((dataRaw, index) =>
                {
                    var row = new DataGridViewRow();
                    row.CreateCells(dgv);
                    row.Cells[1].Value = index + 1;
                    row.Cells[2].Value = dataRaw[0];
                    row.Cells[3].Value = dataRaw[1];
                    row.Cells[4].Value = dataRaw[2].Length >= 32 ? dataRaw[2] : "";
                    row.Cells[7].Value = dataRaw.FirstOrDefault(x => x.Contains("c_user"));
                    row.Cells[8].Value = dataRaw.FirstOrDefault(x => x.Contains("EAA"));
                    return row;
                }).ToList();

                dgv.Invoke((Action)(() => dgv.Rows.AddRange(rowsToAdd.ToArray())));
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var maxThread = (int)numMaxThread.Value;
            var delays = (int)numDelays.Value;
            var typeLogin = cbbTypeLogin.SelectedIndex;
            var typeProxy = cbbTypeProxy.SelectedIndex;
            var limitThreadUse = (int)numLimitThreadUse.Value;

            if (typeProxy != 0)
            {
                var lstProxy = File.ReadLines("Data//Proxy.txt");

                foreach(var proxy in lstProxy)
                {
                    var proxyService = new ProxyService(proxy, "", typeProxy, limitThreadUse);
                    _proxyServices.Add(proxyService);
                }
            }
        }

        private void rtbLinksBM_TextChanged(object sender, EventArgs e)
        {
            int linkCount = rtbLinksBM.Lines.Count(x => x.Contains("https://fb.me/"));
            lbTotalLinkBM.Text = $"Tổng link: {linkCount}";
        }

        private void rtbMailPass_TextChanged(object sender, EventArgs e)
        {
            int mailpassCount = rtbMailPass.Lines.Count(x => x.Contains("|"));
            lbTotalMailPass.Text = $"Tổng mail|pass: {mailpassCount}";
        }

        private void cbbTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex == 1)
            {
                tbCustomName.Visible = true;
            }
            else
            {
                tbCustomName.Visible = false;
            }
        }

        private enum SelectionMode
        {
            All,
            None,
            Selected,
            Toggle
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    dgv.CurrentRow.Cells[0].Value = !Convert.ToBoolean(dgv.CurrentRow.Cells[0].Value);
                }
                catch { }
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgv.CurrentRow.Cells[0].Value = !Convert.ToBoolean(dgv.CurrentRow.Cells[0].Value);
            }
            catch { }
        }
    }
}
