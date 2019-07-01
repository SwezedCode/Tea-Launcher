using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Net;

namespace TeaClientLauncher
{
    public partial class Settings : MetroForm
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            sLbl.Text = "Settings For " + Login.storedUsername;
        }

        private void hwidBtn_Click(object sender, EventArgs e)
        {
            if(Login.purchased_mc != "1" || Login.purchased_mcv3 != "1")
            {
                String clipboardType = "";

                String oldText = "";
                Image oldImage = null;
                StringCollection oldFile = null;

                if(Clipboard.ContainsText())
                {
                    oldText = Clipboard.GetText();
                    clipboardType = "text";
                }else if (Clipboard.ContainsImage())
                {
                    oldImage = Clipboard.GetImage();
                    clipboardType = "image";
                }else if (Clipboard.ContainsFileDropList())
                {
                    oldFile = Clipboard.GetFileDropList();
                    clipboardType = "file";
                }

                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine("java -jar C:\\Tea\\launcher\\scripts\\HWID.jar");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();

                string response = new WebClient().DownloadString("https://teaclient.com/api/updatehwidmc.php?username=" + Login.storedUsername + "&password=" + encode(Login.storedPassword) + "&hwid=" + Clipboard.GetText()).ToString();
                switch (response)
                {
                    case "updated":
                        errorLbl.Text = "Your HWID has been updated.";
                        errorLbl.ForeColor = Color.LawnGreen;
                        break;
                    case "error":
                        errorLbl.Text = "There was an error updating your HWID.";
                        errorLbl.ForeColor = Color.Firebrick;
                        break;
                }

                switch(clipboardType)
                {
                    case "text":
                        Clipboard.SetText(oldText.ToString());
                        break;
                    case "image":
                        Clipboard.SetImage(oldImage);
                        break;
                    case "file":
                        Clipboard.SetFileDropList(oldFile);
                        break;
                }

            }else
            {
                errorLbl.Text = "Couldn't update hwid due to that you don't own Minecraft - v2 or v3.";
            }
        }

        private string encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private void IPBtn_Click(object sender, EventArgs e)
        {
            string ip = new WebClient().DownloadString("https://api.ipify.org/");
            string response = new WebClient().DownloadString("https://teaclient.com/api/updateip.php?username=" + Login.storedUsername + "&password=" + encode(Login.storedPassword) + "&ip=" + ip).ToString();
            switch (response)
            {
                case "updated":
                    errorLbl.Text = "Your IP has been updated.";
                    errorLbl.ForeColor = Color.LawnGreen;
                    break;
                case "city":
                    errorLbl.Text = "The IP Address city does not match the city you have set.";
                    errorLbl.ForeColor = Color.Firebrick;
                    break;
                case "error":
                    errorLbl.Text = "There was an error updating your IP.";
                    errorLbl.ForeColor = Color.Firebrick;
                    break;
            }
        }

        private const string urlPattern = "https://ifconfig.co/json";
        private string getIPData(string dataToRecieve)
        {
            string url = string.Format(urlPattern);

            using (var wc = new WebClient())
            {
                var json = wc.DownloadString(url);

                Newtonsoft.Json.Linq.JToken token = Newtonsoft.Json.Linq.JObject.Parse(json);
                string post = token.SelectToken(dataToRecieve).ToString();

                return post;
            }
        }

        private void changeCityBtn_Click(object sender, EventArgs e)
        {
            if(cityChangeLicense.Text != "")
            {
                string response = new WebClient().DownloadString("https://teaclient.com/api/updatecity.php?username=" + Login.storedUsername + "&password=" + encode(Login.storedPassword) + "&license=" + cityChangeLicense.Text);
                switch(response)
                {
                    case "updated":
                        Login login = new Login("");
                        this.Hide();
                        login.Show();
                        break;
                    case "invalid license":
                        errorLbl.Text = "The license you provided was invalid.";
                        errorLbl.ForeColor = Color.Firebrick;
                        break;
                    case "error":
                        errorLbl.Text = "There was an error updating your City.";
                        errorLbl.ForeColor = Color.Firebrick;
                        break;
                }
            }
            else
            {
                errorLbl.Text = "The city license cannot be blank.";
                errorLbl.ForeColor = Color.Firebrick;
            }
        }

        private void buyCityChangeBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://rocketr.net/buy/4aff015f6e56");
        }

        private void homeLbl_Click(object sender, EventArgs e)
        {
            Tea tea = new Tea();
            this.Hide();
            tea.Show();
        }

        private void homePanel_Click(object sender, EventArgs e)
        {
            Tea tea = new Tea();
            this.Hide();
            tea.Show();
        }

        private void newsLbl_Click(object sender, EventArgs e)
        {
            News tea = new News();
            this.Hide();
            tea.Show();
        }

        private void newsPanel_Click(object sender, EventArgs e)
        {
            News tea = new News();
            this.Hide();
            tea.Show();
        }

        private void cheatLbl_Click(object sender, EventArgs e)
        {
            TeaCheats tea = new TeaCheats();
            this.Hide();
            tea.Show();
        }

        private void cheatPanel_Click(object sender, EventArgs e)
        {
            TeaCheats tea = new TeaCheats();
            this.Hide();
            tea.Show();
        }

        private void supportLbl_Click(object sender, EventArgs e)
        {
            Help tea = new Help();
            this.Hide();
            tea.Show();
        }

        private void supportPanel_Click(object sender, EventArgs e)
        {
            Help tea = new Help();
            this.Hide();
            tea.Show();
        }

        private void homeLbl_MouseEnter(object sender, EventArgs e)
        {
            homeLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
            homePanel.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void homePanel_MouseEnter(object sender, EventArgs e)
        {
            homeLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
            homePanel.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void newsLbl_MouseEnter(object sender, EventArgs e)
        {
            newsLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
            newsPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void newsPanel_MouseEnter(object sender, EventArgs e)
        {
            newsLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
            newsPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void cheatLbl_MouseEnter(object sender, EventArgs e)
        {
            cheatLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
            cheatPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void cheatPanel_MouseEnter(object sender, EventArgs e)
        {
            cheatLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
            cheatPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void supportLbl_MouseEnter(object sender, EventArgs e)
        {
            supportLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
            supportPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void supportPanel_MouseEnter(object sender, EventArgs e)
        {
            supportLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
            supportPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void homeLbl_MouseLeave(object sender, EventArgs e)
        {
            homeLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
            homePanel.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void homePanel_MouseLeave(object sender, EventArgs e)
        {
            homeLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
            homePanel.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void newsLbl_MouseLeave(object sender, EventArgs e)
        {
            newsLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
            newsPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void newsPanel_MouseLeave(object sender, EventArgs e)
        {
            newsLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
            newsPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void cheatLbl_MouseLeave(object sender, EventArgs e)
        {
            cheatLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
            cheatPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void cheatPanel_MouseLeave(object sender, EventArgs e)
        {
            cheatLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
            cheatPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void supportLbl_MouseLeave(object sender, EventArgs e)
        {
            supportLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
            supportPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void supportPanel_MouseLeave(object sender, EventArgs e)
        {
            supportLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
            supportPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Maroon;
        }

        private void metroLabel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
        }

        private void metroLabel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Maroon;
        }
    }
}
