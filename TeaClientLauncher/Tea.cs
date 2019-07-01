using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace TeaClientLauncher
{
    public partial class Tea : MetroForm
    {
        public Tea()
        {
            InitializeComponent();
        }

        private void Tea_Load(object sender, EventArgs e)
        {
            welcomeLbl.Text = "Welcome back " + Login.storedUsername + "!";
            timer1.Start();
            timer1.Interval = 1;
            BringToFront();
            Activate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
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

        private void cheatLbl_MouseEnter(object sender, EventArgs e)
        {
            cheatPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
            cheatLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void cheatPanel_MouseEnter(object sender, EventArgs e)
        {
            cheatPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
            cheatLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
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

        private void panel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void newsLbl_Click(object sender, EventArgs e)
        {
            News tea = new News();
            this.Hide();
            tea.Show();
        }

        private void supportLbl_Click(object sender, EventArgs e)
        {
            Help tea = new Help();
            this.Hide();
            tea.Show();
        }

        private void newsPanel_Click(object sender, EventArgs e)
        {
            News tea = new News();
            this.Hide();
            tea.Show();
        }

        private void supportPanel_Click(object sender, EventArgs e)
        {
            Help tea = new Help();
            this.Hide();
            tea.Show();
        }

        private void settingsLbl_MouseEnter(object sender, EventArgs e)
        {
            settingsPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
            settingsLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void settingsPanel_MouseEnter(object sender, EventArgs e)
        {
            settingsPanel.BackColor = Color.FromArgb(255, 42, 42, 42);
            settingsLbl.BackColor = Color.FromArgb(255, 42, 42, 42);
        }

        private void settingsPanel_MouseHover(object sender, EventArgs e)
        {
            settingsPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
            settingsLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void settingsLbl_MouseLeave(object sender, EventArgs e)
        {
            settingsPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
            settingsLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void settingsPanel_MouseLeave(object sender, EventArgs e)
        {
            settingsPanel.BackColor = Color.FromArgb(255, 38, 38, 38);
            settingsLbl.BackColor = Color.FromArgb(255, 38, 38, 38);
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
    }
}
