using Newtonsoft.Json;
using Slang.IDE.Tools.CrashReport.Properties;
using System.Diagnostics;
using System.Net;
using System.Text;

namespace Slang.IDE.Tools.CrashReport
{
    public partial class FrmMain : Form
    {
        public FrmMain(string exception)
        {
            InitializeComponent();
            TxtException.Text = exception.Trim();
        }

        private async void BtnSendReport_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = new
                {
                    CreatedOn = DateTime.Now,
                    ExceptionMessage = TxtException.Text,
                    UserExtraInformation = TxtExtraInfo.Text,
                    UserId = Guid.Empty
                };

                using var httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri("https://api.enaliosnaxos.com");
                var response = await httpClient.PostAsync("api/crash", new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8));

                if(response.StatusCode != HttpStatusCode.OK)
                {
                    throw new HttpRequestException(await response.Content.ReadAsStringAsync());
                }


                MessageBox.Show("Thank you very much for your patience. We will investigate what happened and we will fix as soon as possible.", "Report has sent...", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An exception has occured. {ex.Message}", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static void OpenIde()
        {
            var openIde = MessageBox.Show("Do you want to open again the SlangIDE?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (openIde == DialogResult.Yes)
            {
                Process.Start("slangdev.exe");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var error = $"{DateTime.Now}{Environment.NewLine}Exception Error: {TxtException.Text}{Environment.NewLine}User's extra information: {TxtExtraInfo.Text}";
            var text = string.Empty;

            var dumpPath = Settings.Default["CrashDumpsFolder"].ToString();
            var fileName = Path.Combine(dumpPath, $"crash_dump_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}.txt");

            if (!Directory.Exists(dumpPath))
            {
                Directory.CreateDirectory(dumpPath);
            }

            if (File.Exists(fileName))
            {
                text = File.ReadAllText(fileName);
            }

            text = $"{text}{(string.IsNullOrEmpty(text) ? "" : Environment.NewLine)}{(string.IsNullOrEmpty(text) ? "" : Environment.NewLine)}{error}";

            try
            {
                File.WriteAllText(fileName, text);
                MessageBox.Show($"Crash Report has been saved in: {fileName}", "Info...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An exception has occured. {ex.Message}", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            OpenIde();
        }
    }
}
