using MetaCare.Dtos;
using MetaCare.Handlers;
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
    }
}
