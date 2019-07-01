using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace TeaClientLauncher
{
    public partial class Help : MetroForm
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            BringToFront();
            Activate();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://teaclient.com/tos.php");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://en.wikipedia.org/wiki/DLL_injection");
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

        private void metroLabel7_Click(object sender, EventArgs e)
        {
            Settings tea = new Settings();
            this.Hide();
            tea.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Settings tea = new Settings();
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

        private void metroLabel7_MouseEnter(object sender, EventArgs e)
        {
            metroLabel7.BackColor = Color.FromArgb(255, 42, 42, 42);
            panel4.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            metroLabel7.BackColor = Color.FromArgb(255, 42, 42, 42);
            panel4.BackColor = Color.FromArgb(255, 42, 42, 42);
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
            newsPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
            newsPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void newsPanel_MouseLeave(object sender, EventArgs e)
        {
            newsPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
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

        private void metroLabel7_MouseLeave(object sender, EventArgs e)
        {
            metroLabel7.BackColor = Color.FromArgb(255, 38, 38, 38);
            panel4.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            metroLabel7.BackColor = Color.FromArgb(255, 38, 38, 38);
            panel4.BackColor = Color.FromArgb(255, 38, 38, 38);
        }
    }
}
