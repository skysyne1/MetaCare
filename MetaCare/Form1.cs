using MetaCare.Dtos;
using MetaCare.Handlers;
using MetaCare.Helpers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaCare
{
    public partial class Form1 : Form
    {
        private FacebookHandlerDto FacebookHandlerDto;
        private FacebookHandler facebookHandler;

        public Form1(FacebookHandlerDto facebookHandlerDto)
        {
            InitializeComponent();
            FacebookHandlerDto = facebookHandlerDto;
            facebookHandler = new FacebookHandler(facebookHandlerDto);
        }

        private void SetCellAccount(int indexRow, int column, object value)
        {
            DatagridviewHelper.SetStatusDataGridView(this.dgv, indexRow, column, value);
        }

        private void SetCellAccount(DataGridView dgv, int indexRow, int column, object value)
        {
            DatagridviewHelper.SetStatusDataGridView(dgv, indexRow, column, value);
        }

        private async void btnLoadTKQC_Click(object sender, System.EventArgs e)
        {
            int typeLoadTKQC = (int)cbbTypeLoadTKQC.SelectedIndex;
            switch (typeLoadTKQC)
            {
                case 0:
                    await LoadAllAdsAccount();
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }

        private async Task LoadAllAdsAccount()
        {
            var status = await facebookHandler.LoginFacebook();
            if (status != FacebookHandler.Status.Success)
            {
                MessageBox.Show($"Login thất bại =>{status}", "Thông báo");
                return;
            }

            var adsAccountDatas = await facebookHandler.LoadAllAdAccount();
            
            foreach (var adAccountDto in adsAccountDatas)
            {
                int add = 0;

                lock (dgv)
                {
                    dgv.Invoke((Action)delegate
                    {
                        add = dgv.Rows.Add();
                    });
                }

                DataGridViewRow row = dgv.Rows[add];

                row.Cells[1].Value = (add + 1);

                Task.Run(() =>
                {
                    SetDataAdAccount(row.Index, adAccountDto);
                });
            }
        }

        private void SetDataAdAccount(int index, AdAccountDto adAccount)
        {
            SetCellAccount(index, 1, adAccount.Id);
            SetCellAccount(index, 2, adAccount.Name);
            SetCellAccount(index, 3, adAccount.Currency);
            SetCellAccount(index, 4, adAccount.Limit);
            SetCellAccount(index, 5, adAccount.Threshold);
            SetCellAccount(index, 6, adAccount.Balance);
            SetCellAccount(index, 7, adAccount.Spent);
            SetCellAccount(index, 8, adAccount.Payment);
            SetCellAccount(index, 9, $"{adAccount.BusinessCountryCode}/{adAccount.TimeZone}");
            SetCellAccount(index, 10, adAccount.CampaignCount); ;
            SetCellAccount(index, 11, adAccount.LimitSet);
            SetCellAccount(index, 12, adAccount.Owner);
            SetCellAccount(index, 13, adAccount.Status);
            SetCellAccount(index, 14, "Done");
        }

        private void checkPTTTToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void checkTKQCToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void dánTKQCToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            string text = Clipboard.GetText();

            // Nếu clipboard trống, không làm gì cả
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Clipboard trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Task.Run(() =>
            {
                // Tách các dòng từ Clipboard và loại bỏ dòng trống
                string[] datas = text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(x => x.Trim())
                                     .Where(x => !string.IsNullOrEmpty(x))
                                     .ToArray();

                if (datas.Length == 0)
                {
                    MessageBox.Show("Không có dữ liệu hợp lệ để dán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo danh sách các dòng mới trước khi cập nhật DataGridView
                var newRows = new List<DataGridViewRow>();

                for (int i = 0; i < datas.Length; i++)
                {
                    var row = new DataGridViewRow();
                    row.CreateCells(dgv); // Tạo các ô dữ liệu phù hợp với dgv
                    row.Cells[1].Value = (i + 1).ToString();  // Cột số thứ tự
                    row.Cells[2].Value = datas[i].Trim();     // Cột dữ liệu (bỏ ký tự `\r`)
                    newRows.Add(row);
                }

                // Cập nhật UI trên luồng chính
                dgv.BeginInvoke(new Action(() =>
                {
                    dgv.Rows.Clear(); // Xóa dữ liệu cũ
                    dgv.Rows.AddRange(newRows.ToArray()); // Thêm tất cả dòng một lần
                }));
            });

        }
    }
}
