using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TeaClientLauncher
{
    public partial class TeaMCv3 : MetroForm
    {
        public TeaMCv3()
        {
            InitializeComponent();
        }

        private string _title;
        private double _price;
        private bool _purchased;

        bool hasAuthority;

        public TeaMCv3(string title, double price, bool purchased)
        {
            InitializeComponent();
            _title = title;
            _price = price;
            _purchased = purchased;
        }

        private string getTitle()
        {
            return _title;
        }

        private double getPrice()
        {
            return _price;
        }

        private bool isPurchased()
        {
            return _purchased;
        }

        private bool canLaunch()
        {
            return hasAuthority;
        }

        private void TeaMC_Load(object sender, EventArgs e)
        {
            
        }

        private void currency_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (currency.Text == "USD")
            {
                price.Text = getPrice() + "$";
            }
            if (currency.Text == "EUR")
            {
                price.Text = CurrencyConversion(Convert.ToDecimal(getPrice()), "USD", "EUR").ToString().Substring(0, 4) + "€";
            }
            if (currency.Text == "CAD")
            {
                price.Text = CurrencyConversion(Convert.ToDecimal(getPrice()), "USD", "CAD").ToString().Substring(0, 4) + "C$";
            }
            if (currency.Text == "AUD")
            {
                price.Text = CurrencyConversion(Convert.ToDecimal(getPrice()), "USD", "AUD").ToString().Substring(0, 4) + "A$";
            }
            if (currency.Text == "SEK")
            {
                price.Text = CurrencyConversion(Convert.ToDecimal(getPrice()), "USD", "SEK").ToString().Substring(0, 4) + "kr";
            }
            if (currency.Text == "RUBLE")
            {
                price.Text = CurrencyConversion(Convert.ToDecimal(getPrice()), "USD", "RUB").ToString().Substring(0, 3) + "₽";
            }
        }

        private const string urlPattern = "http://rate-exchange-1.appspot.com/currency?from={0}&to={1}";
        public string CurrencyConversion(decimal amount, string fromCurrency, string toCurrency)
        {
            string url = string.Format(urlPattern, fromCurrency, toCurrency);

            using (var wc = new WebClient())
            {
                var json = wc.DownloadString(url);

                Newtonsoft.Json.Linq.JToken token = Newtonsoft.Json.Linq.JObject.Parse(json);
                decimal exchangeRate = (decimal)token.SelectToken("rate");

                return (amount * exchangeRate).ToString();
            }
        }

        private void launch_or_purchase_button_Click(object sender, EventArgs e)
        {
            if (isPurchased())
            {

            }
            else
            {
                Process.Start("https://teaclient.com/beforebuying.php");
            }
        }

        private void java_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.oracle.com/technetwork/java/javase/downloads/jre8-downloads-2133155.html");
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            TeaCheats tea = new TeaCheats();
            this.Hide();
            tea.Show();
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
            metroLabel2.BackColor = Color.Red;
        }

        private void metroLabel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
            metroLabel2.BackColor = Color.Red;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Maroon;
            metroLabel2.BackColor = Color.Maroon;
        }

        private void metroLabel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Maroon;
            metroLabel2.BackColor = Color.Maroon;
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void license_button_Click(object sender, EventArgs e)
        {
            License license = new License(getTitle());
            this.Hide();
            license.Show();
        }

        private void discount_Click(object sender, EventArgs e)
        {
            Discount dc = new Discount(getTitle());
            this.Hide();
            dc.Show();
        }

        private void TeaMCv3_Load(object sender, EventArgs e)
        {
            title.Text = getTitle();
            price.Text = getPrice().ToString() + "$";

            if (isPurchased())
            {
                price.Text = "Owned";
                currencyLbl.Visible = false;
                currency.Visible = false;

                if(Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\Tea_v3"))
                {
                    license_button.Text = "Reinstall";
                }else
                {
                    license_button.Visible = false;
                }
                launch_or_purchase_button.Text = "Launch";
                hasAuthority = true;

            }

            BringToFront();
            Activate();
        }

        private void launch_or_purchase_button_Click_1(object sender, EventArgs e)
        {
            if (isPurchased())
            {
                Process[] mc = Process.GetProcessesByName("MinecraftLauncher");
                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\1.8.8") || !File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\1.8.8\1.8.8.jar") || !File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\1.8.8\1.8.8.json"))
                {
                    DialogResult dr = MetroMessageBox.Show(this, "\n\nYou need to run Minecraft 1.8.8 at least once.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        BringToFront();
                        Activate();
                    }
                    return;
                }

                if (mc.Length != 0)
                {
                    DialogResult dr = MetroMessageBox.Show(this, "\n\nYou need to close the Minecraft Launcher.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        BringToFront();
                        Activate();
                    }
                    return;
                }

                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\Tea_v3"))
                {           
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\Tea_v3");
                    new WebClient().DownloadFile("https://teaclient.com/api/download/Tea.jar", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\Tea_v3\Tea_v3.jar");
                    new WebClient().DownloadFile("https://teaclient.com/api/download/Tea.json", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\Tea_v3\Tea_v3.json");

                    string text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\launcher_profiles.json");
                    if (!text.Contains("\"1.8.8\""))
                    {
                        DialogResult axd = MetroMessageBox.Show(this, "\n\nCouldn't find 1.8.8 profile. Please create a profile named 1.8.8 and make sure it runs on version 1.8.8", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (axd == DialogResult.OK)
                        {
                            BringToFront();
                            Activate();
                        }
                        return;
                    }

                    using (var sourceFile = File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\launcher_profiles.json"))
                    {
                        string tempFile = Path.Combine(Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\launcher_profiles.json"), "launcher_profiles_temp.json");
                        using (var tempFileStream = new StreamWriter(tempFile))
                        {
                            string line;
                            while ((line = sourceFile.ReadLine()) != null)
                            {
                                line = line.Replace("\"1.8.8\"", "\"Tea_v3\"");
                                tempFileStream.WriteLine(line);
                            }
                        }
                    }
                    File.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\launcher_profiles_temp.json", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\launcher_profiles.json", null);

                    DialogResult dr = MetroMessageBox.Show(this, "\n\nTea_v3 profile has been added on your Minecraft launcher.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        BringToFront();
                        Activate();
                    }

                    //errorLbl.Text = "Tea_v3 profile has been added to your launcher! Launching...";
                    //errorLbl.ForeColor = Color.LawnGreen;
                }

                errorLbl.Text = "Launching...";
                errorLbl.ForeColor = Color.White;

                try
                {
                    if(Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Minecraft") || Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\minekampf") || Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Minecraft Launcher"))
                    {
                        if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\minekampf\MinecraftLauncher.exe"))
                        {
                            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\minekampf\MinecraftLauncher.exe");
                            return;
                        }

                        //minekampf
                        if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Minecraft Launcher\MinecraftLauncher.exe"))
                        {
                            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Minecraft Launcher\MinecraftLauncher.exe");
                            return;
                        }

                        if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Minecraft\MinecraftLauncher.exe"))
                        {
                            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Minecraft\MinecraftLauncher.exe");
                            return;
                        }

                        if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Minecraft Launcher\MinecraftLauncher.exe") && !File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Minecraft\MinecraftLauncher.exe"))
                        {
                            DialogResult dr = MetroMessageBox.Show(this, "\n\nCouldn't find MinecraftLauncher.exe, please reinstall Minecraft at C:\\Program Files (86)\\Minecraft\\", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (dr == DialogResult.OK)
                            {
                                BringToFront();
                                Activate();
                                return;
                            }
                        }

                    }
                    else
                    {
                        DialogResult dr = MetroMessageBox.Show(this, "\n\nCouldn't find Minecraft. Please install Minecraft at C:\\Program Files (86)\\Minecraft\\", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (dr == DialogResult.OK)
                        {
                            BringToFront();
                            Activate();
                        }
                        return;
                    }
                }
                catch(Exception ex)
                {
                    DialogResult dr = MetroMessageBox.Show(this, "\n\nThere was an error when launching Minecraft.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        BringToFront();
                        Activate();
                    }
                    return;
                }
            }
            else
            {
                Process.Start("https://teaclient.com/beforebuying.php");
            }
        }

        private void license_button_Click_1(object sender, EventArgs e)
        {
            if(isPurchased())
            {
                errorLbl.Text = "Reinstalling...";
                errorLbl.ForeColor = Color.White;

                if(Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\Tea_v3"))
                {
                    if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\Tea_v3\Tea_v3.jar"))
                        File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\Tea_v3\Tea_v3.jar");

                    if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\Tea_v3\Tea_v3.json"))
                        File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\Tea_v3\Tea_v3.json");

                    Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\Tea_v3");
                }

                if(!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\Tea_v3"))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\Tea_v3");
                    new WebClient().DownloadFile("https://teaclient.com/api/download/Tea.jar", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\Tea_v3\Tea_v3.jar");
                    new WebClient().DownloadFile("https://teaclient.com/api/download/Tea.json", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\Tea_v3\Tea_v3.json");
                }

                errorLbl.Text = "Successfully reinstalled Tea.";

            }
            else
            {
                License license = new License(getTitle());
                this.Hide();
                license.Show();
            }
        }

        private void backbutton_Click_1(object sender, EventArgs e)
        {
            TeaCheats tea = new TeaCheats();
            this.Hide();
            tea.Show();
        }

        private void currency_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (currency.Text == "USD")
            {
                price.Text = getPrice() + "$";
            }
            if (currency.Text == "EUR")
            {
                price.Text = CurrencyConversion(Convert.ToDecimal(getPrice()), "USD", "EUR").ToString().Substring(0, 4) + "€";
            }
            if (currency.Text == "CAD")
            {
                price.Text = CurrencyConversion(Convert.ToDecimal(getPrice()), "USD", "CAD").ToString().Substring(0, 4) + "C$";
            }
            if (currency.Text == "AUD")
            {
                price.Text = CurrencyConversion(Convert.ToDecimal(getPrice()), "USD", "AUD").ToString().Substring(0, 4) + "A$";
            }
            if (currency.Text == "SEK")
            {
                price.Text = CurrencyConversion(Convert.ToDecimal(getPrice()), "USD", "SEK").ToString().Substring(0, 4) + "kr";
            }
            if (currency.Text == "RUBLE")
            {
                price.Text = CurrencyConversion(Convert.ToDecimal(getPrice()), "USD", "RUB").ToString().Substring(0, 3) + "₽";
            }
        }

        private void java_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.oracle.com/technetwork/java/javase/downloads/jre8-downloads-2133155.html");
        }

        private void features_Click(object sender, EventArgs e)
        {
            Process.Start("https://teaclient.com/features.php");
        }

        private void screenshots_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseEnter_1(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
        }

        private void panel2_MouseLeave_1(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Maroon;
        }

        private void metroLabel2_MouseEnter_1(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
        }

        private void metroLabel2_MouseLeave_1(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Maroon;
        }
    }
}
