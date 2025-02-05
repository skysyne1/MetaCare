using MetaCare.Dtos;
using MetaCare.Handlers;
using System;
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
            dgv.Rows.Clear();

            var clipboardText = Clipboard.GetText();

            Task.Run(() =>
            {
                var lines = clipboardText.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(line => line.Trim().Replace("\r", ""))
                                         .ToArray();

                dgv.Invoke(new MethodInvoker(() =>
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        int rowIndex = dgv.Rows.Add();
                        DataGridViewRow row = dgv.Rows[rowIndex];

                        SetCellAccount(rowIndex, 1, (i + 1).ToString());
                        SetCellAccount(rowIndex, 2, lines[i]);
                    }
                }));
            });

        }
    }
}
