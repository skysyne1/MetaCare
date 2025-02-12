using MetaCare.Dtos;
using MetaCare.Handlers;
using MetaCare.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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

        private void btnLoadTKQC_Click(object sender, System.EventArgs e)
        {
            int typeLoadTKQC = (int)cbbTypeLoadTKQC.SelectedIndex;
            switch (typeLoadTKQC)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
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
