using MetaCare.Containers;
using MetaCare.Dtos;
using MetaCare.Handlers;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MetaCare
{
    public partial class Form1 : Form
    {
        private FacebookHandlerDto FacebookHandlerDto;
        private FacebookHandler facebookHandler;

        public Form1(FacebookHandlerDto facebookHandlerDto)
        {
            InitializeComponent();
            OnLoad();
            FacebookHandlerDto = facebookHandlerDto;
            facebookHandler = new FacebookHandler(facebookHandlerDto);
        }

        private void OnLoad()
        {
            cbbTypeLoadTKQC.SelectedIndex = 0;
        }

        private async void btnLoadTKQC_Click(object sender, System.EventArgs e)
        {
            dgv.Rows.Clear();
            int typeLoadTKQC = (int)cbbTypeLoadTKQC.SelectedIndex;
            if (!FacebookHandlerDto.IsLoggedIn)
            {
                progressLoad.Style = ProgressBarStyle.Marquee; // Hiển thị trạng thái không xác định
                progressLoad.Visible = true;
                var status = await facebookHandler.LoginFacebook();
                if (status == FacebookHandler.Status.Success)
                {
                    FacebookHandlerDto.IsLoggedIn = true;
                    var exist = FacebookContainer.Instance.FacebookHandlers.Where(x => x.Account == FacebookHandlerDto.Account).FirstOrDefault();
                    if (exist != null)
                    {
                        exist.Account = FacebookHandlerDto.Account;
                        exist.ApiClient = FacebookHandlerDto.ApiClient;
                        exist.IsLoggedIn = FacebookHandlerDto.IsLoggedIn;
                    }
                    else
                    {
                        FacebookContainer.Instance.FacebookHandlers.Add(FacebookHandlerDto);
                    }
                }
                else
                {
                    progressLoad.Visible = false;
                    MessageBox.Show("Login thất bại vui lòng thử lại!");
                    return;
                }
            }
            switch (typeLoadTKQC)
            {
                case 0:
                    progressLoad.Style = ProgressBarStyle.Continuous; // Hiển thị trạng thái có kiểm soát
                    progressLoad.Value = 0;
                    progressLoad.Visible = true;

                    var adAccounts = await facebookHandler.LoadAllAdAccount();
                    int totalAccounts = adAccounts.Count;
                    int currentIndex = 0;

                    foreach (var adAccount in adAccounts)
                    {
                        if (adAccount == null)
                        {
                            currentIndex++;
                            progressLoad.Value = (int)((currentIndex / (double)totalAccounts) * 100);
                            continue;
                        }
                        dgv.Rows.Add(false, dgv.Rows.Count, adAccount.Id, adAccount.Name, adAccount.Currency, adAccount.Limit, adAccount.Threshold, adAccount.Balance, adAccount.Spent, adAccount.Payment, $"{adAccount.BusinessCountryCode}/{adAccount.TimeZone}", adAccount.CampaignCount != null ? adAccount.CampaignCount : "0", adAccount.Status);
                        
                        currentIndex++;
                        progressLoad.Value = (int)((currentIndex / (double)totalAccounts) * 100);
                    }
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }
    }
}
