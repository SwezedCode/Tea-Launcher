using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using TeaClientLauncher.Properties;

namespace TeaClientLauncher
{
    public partial class TeaCheats : MetroForm
    {
        public TeaCheats()
        {
            InitializeComponent();
        }

        Product minecraft = new Product("Minecraft - v2", Convert.ToDouble(new WebClient().DownloadString("https://teaclient.com/api/price.txt").ToString().Split(':')[0]), Login.purchased_mc.ToString().Contains("1") ? true : false);
        Product minecraft_v3 = new Product("Minecraft - v3", Convert.ToDouble(new WebClient().DownloadString("https://teaclient.com/api/price.txt").ToString().Split(':')[1]), Login.purchased_mcv3.ToString().Contains("1") ? true : false);
        Product tf2 = new Product("Team Fortress 2", Convert.ToDouble(new WebClient().DownloadString("https://teaclient.com/api/price.txt").ToString().Split(':')[2]), Login.purchased_tf2.ToString().Contains("1") ? true : false);

        private void TeaCheats_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();

            p1_title.Text = minecraft.getName();
            p1_price.Text = minecraft.isPurchased() ? "Owned" : "Unavailable";
            if (minecraft.isPurchased())
            {
                p1_button.Text = "Details";
                p1_button.BackColor = Color.FromArgb(255, 64, 193, 92);
            }
            else
            {
                p1_button.Text = "Details";
                p1_button.BackColor = Color.FromArgb(255, 255, 171, 43);
            }

            p2_title.Text = tf2.getName();
            p2_price.Text = tf2.isPurchased() ? "Owned" : "Unavailable";
            if (tf2.isPurchased())
            {

                p2_button.Text = "Details";
                p2_button.BackColor = Color.FromArgb(255, 64, 193, 92);
            }
            else
            {
                p2_button.Text = "Details";
                p2_button.BackColor = Color.FromArgb(255, 255, 171, 43);
            }

            p3_title.Text = minecraft_v3.getName();
            p3_price.Text = minecraft_v3.isPurchased() ? "Owned" : minecraft_v3.getPrice().ToString() + "$";
            if (minecraft_v3.isPurchased())
            {
                p3_button.Text = "Details";
                p3_button.BackColor = Color.FromArgb(255, 64, 193, 92);
            }
            else
            {
                p3_button.Text = "Details";
                p3_button.BackColor = Color.FromArgb(255, 255, 171, 43);
            }

            BringToFront();
            Activate();
        }

        private void p1_button_Click(object sender, EventArgs e)
        {
            TeaMC tea = new TeaMC(minecraft.getName(), minecraft.getPrice(), minecraft.isPurchased());
            this.Hide();
            tea.Show();
        }

        private void p2_button_Click(object sender, EventArgs e)
        {
            TeaTF2 tea = new TeaTF2(tf2.getName(), tf2.getPrice(), tf2.isPurchased());
            this.Hide();
            tea.Show();
        }

        private void homeLbl_MouseLeave(object sender, EventArgs e)
        {
            homePanel.BackColor = Color.FromArgb(255, 38, 38, 38);
            homeLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void homePanel_MouseLeave(object sender, EventArgs e)
        {
            homePanel.BackColor = Color.FromArgb(255, 38, 38, 38);
            homeLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void homeLbl_MouseEnter(object sender, EventArgs e)
        {
            homePanel.BackColor = Color.FromArgb(255, 42, 42, 42);
            homeLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void homePanel_MouseEnter(object sender, EventArgs e)
        {
            homePanel.BackColor = Color.FromArgb(255, 42, 42, 42);
            homeLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void newsPanel_MouseEnter(object sender, EventArgs e)
        {
            newsPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
            newsLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void newsLbl_MouseEnter(object sender, EventArgs e)
        {
            newsPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
            newsLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void supportLbl_MouseEnter(object sender, EventArgs e)
        {
            supportPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
            supportLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void supportPanel_MouseEnter(object sender, EventArgs e)
        {
            supportPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
            supportLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void newsPanel_MouseLeave(object sender, EventArgs e)
        {
            newsPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
            newsLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void newsLbl_MouseLeave(object sender, EventArgs e)
        {
            newsPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
            newsLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void cheatLbl_MouseLeave(object sender, EventArgs e)
        {
            cheatPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
            cheatLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void cheatPanel_MouseLeave(object sender, EventArgs e)
        {
            cheatPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
            cheatLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void supportLbl_MouseLeave(object sender, EventArgs e)
        {
            supportPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
            supportLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void supportPanel_MouseLeave(object sender, EventArgs e)
        {
            supportPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
            supportLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
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

        private void p3_button_Click(object sender, EventArgs e)
        {
            TeaMCv3 tea = new TeaMCv3(minecraft_v3.getName(), minecraft_v3.getPrice(), minecraft_v3.isPurchased());
            this.Hide();
            tea.Show();
        }

        private void settingsPanel_Click(object sender, EventArgs e)
        {
            Settings tea = new Settings();
            this.Hide();
            tea.Show();
        }

        private void settingsP_Click(object sender, EventArgs e)
        {
            Settings tea = new Settings();
            this.Hide();
            tea.Show();
        }

        private void settingsPanel_MouseEnter(object sender, EventArgs e)
        {
            settingsP.BackColor = Color.FromArgb(255, 42, 42, 42);
            settingsPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void settingsP_MouseEnter(object sender, EventArgs e)
        {
            settingsP.BackColor = Color.FromArgb(255, 42, 42, 42);
            settingsPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void settingsPanel_MouseLeave(object sender, EventArgs e)
        {
            settingsP.BackColor = Color.FromArgb(255, 38, 38, 38);
            settingsPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void settingsP_MouseLeave(object sender, EventArgs e)
        {
            settingsP.BackColor = Color.FromArgb(255, 38, 38, 38);
            settingsPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
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

        /*public decimal ConvertGOOG(decimal amount, string fromCurrency, string toCurrency)
        {
            WebClient web = new WebClient();
            string apiURL = String.Format("http://finance.google.com/finance/converter?a={0}&from={1}&to={2}", amount, fromCurrency.ToUpper(), toCurrency.ToUpper());
            string response = web.DownloadString(apiURL);
            var split = response.Split((new string[] { "<span class=bld>" }), StringSplitOptions.None);
            var value = split[1].Split(' ')[0];
            decimal rate = decimal.Parse(value, CultureInfo.InvariantCulture);
            return rate;
        }*/

    }

    class Product
    {
        string _name;
        double _price;
        bool _purchased;

        public Product(string name, double price, bool purchased)
        {
            _name = name;
            _price = price;
            _purchased = purchased;
        }

        public string getName()
        {
            return _name;
        }

        public double getPrice()
        {
            return _price;
        }

        public bool isPurchased()
        {
            return _purchased;
        }

    }

}
