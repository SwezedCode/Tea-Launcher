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
using System.IO;
using System.Net;
using MetroFramework;
using System.Diagnostics;

namespace TeaClientLauncher
{
    public partial class Form1 : MetroForm
    {
        private string version = "0.03";
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initialize();
            Focus();
            BringToFront();
            if(!new WebClient().DownloadString("https://teaclient.com/api/launcher_version.txt").Equals(version))
            {
                DialogResult dr = MetroMessageBox.Show(this, "\n\nYour launcher is outdated. Do you want to download now?", "IMPORTANT", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    BringToFront();
                    Activate();

                    if (!File.Exists(@"c:\Tea\launcher\scripts\TeaDownloader.exe"))
                    {
                        new WebClient().DownloadFile("https://teaclient.com/api/download/TeaDownloader.exe", @"c:\Tea\launcher\scripts\TeaDownloader.exe");
                    }

                    Application.Exit();

                    Process cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = true;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.Start();

                    cmd.StandardInput.WriteLine("start C:\\Tea\\launcher\\scripts\\TeaDownloader.exe " + AppDomain.CurrentDomain.BaseDirectory);
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    cmd.WaitForExit();
                }
                else if(dr == DialogResult.Cancel)
                {
                    BringToFront();
                    Activate();
                    Application.Exit();
                }
                return;
            }
            

            timer1.Start();
            timer1.Interval = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count += 1;
            if(count >= 80)
            {
                timer1.Interval = 30;
            }

            if(count == 100)
            {
                Login login = new Login("");
                this.Hide();
                login.Show();
                timer1.Stop();
            }
        }

        private void initialize()
        {
            status.Text = "Initializing";
            if (!Directory.Exists(@"c:\Tea"))
            {
                status.Text = "Creating directory";
                Directory.CreateDirectory(@"c:\Tea");
            }


            if (!Directory.Exists(@"c:\Tea\launcher"))
            {
                status.Text = "Creating directory for launcher";
                Directory.CreateDirectory(@"c:\Tea\launcher");
                if (!Directory.Exists(@"c:\Tea\launcher\scripts"))
                {
                    status.Text = "Creating directory for scripts";
                    Directory.CreateDirectory(@"c:\Tea\launcher\scripts");

                    status.Text = "Downloading discord-rpc.dll";
                    new WebClient().DownloadFile("https://teaclient.com/api/download/discord-rpc.dll", @"c:\Tea\launcher\scripts\discord-rpc.dll");

                    status.Text = "Downloading HWID Grabber";
                    new WebClient().DownloadFile("https://teaclient.com/api/download/HWID.jar", @"c:\Tea\launcher\scripts\HWID.jar");
                }
                if (!Directory.Exists(@"c:\Tea\launcher\downloads"))
                {
                    status.Text = "Creating directory for downloads";
                    Directory.CreateDirectory(@"c:\Tea\launcher\downloads");
                }
            }

            if (!Directory.Exists(@"c:\Tea\launcher\login"))
            {
                status.Text = "Creating directory for login";
                Directory.CreateDirectory(@"c:\Tea\launcher\login");
            }

            status.Text = "Loading login form";
        }

    }
}
