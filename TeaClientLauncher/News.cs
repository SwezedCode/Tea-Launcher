using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace TeaClientLauncher
{
    public partial class News : MetroForm
    {
        public News()
        {
            InitializeComponent();
        }

        private void News_Load(object sender, EventArgs e)
        {
            string rec = new WebClient().DownloadString("https://teaclient.com/api/news.txt");
            rec = rec.Replace("\n", Environment.NewLine);
            newsText.Text = rec.ToString();

            BringToFront();
            Activate();
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

        private void settingsLbl_Click(object sender, EventArgs e)
        {
            Settings tea = new Settings();
            this.Hide();
            tea.Show();
        }

        private void settingsPanel_Click(object sender, EventArgs e)
        {
            Settings tea = new Settings();
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

        private void settingsLbl_MouseEnter(object sender, EventArgs e)
        {
            settingsLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
            settingsPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void settingsPanel_MouseEnter(object sender, EventArgs e)
        {
            settingsLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
            settingsPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
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

        private void settingsLbl_MouseLeave(object sender, EventArgs e)
        {
            settingsLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
            settingsPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void settingsPanel_MouseLeave(object sender, EventArgs e)
        {
            settingsLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
            settingsPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
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
