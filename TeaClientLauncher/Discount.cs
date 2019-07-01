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
using TeaClientLauncher.Properties;

namespace TeaClientLauncher
{
    public partial class Discount : MetroForm
    {
        string _productName;

        public Discount(string productName)
        {
            InitializeComponent();
            _productName = productName;
        }

        string getProductName()
        {
            return _productName;
        }

        private void Discount_Load(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Product minecraft = new Product("Minecraft", Convert.ToDouble(new WebClient().DownloadString("https://teaclient.com/api/price.txt").ToString().Split(':')[0]), Login.purchased_mc.ToString().Contains("1") ? true : false);
            Product tf2 = new Product("Team Fortress 2", Convert.ToDouble(new WebClient().DownloadString("https://teaclient.com/api/price.txt").ToString().Split(':')[1]), Login.purchased_tf2.ToString().Contains("1") ? true : false);
            switch (getProductName())
            {
                case "Minecraft":
                    TeaMC mc = new TeaMC(minecraft.getName(), minecraft.getPrice(), minecraft.isPurchased());
                    this.Hide();
                    mc.Show();
                    break;
                case "Team Fortress 2":
                    TeaTF2 tf = new TeaTF2(tf2.getName(), tf2.getPrice(), tf2.isPurchased());
                    this.Hide();
                    tf.Show();
                    break;
            }
        }

        private string getStatus(string username, string password)
        {
            string mail = new WebClient().DownloadString("https://teaclient.com/api/getmail.php?username=" + username + "&password=" + password).Replace("<pre>", "").Replace("</pre>", "");
            switch (getProductName())
            {
                case "Minecraft":
                    string url_mc = "https://teaclient.com/api/checkpromo.php?username=" + username + "&password=" + password + "&type=mc";
                    string rec_mc = new WebClient().DownloadString(url_mc);

                    if (rec_mc.Contains("not_found"))
                    {
                        errorLbl.Text = "The username was not found.";
                        errorLbl.ForeColor = Color.Firebrick;
                    }

                    if (rec_mc.Contains("already"))
                    {
                        errorLbl.Text = "You already recieved the discount code on your mail.";
                        errorLbl.ForeColor = Color.Firebrick;
                    }

                    if (rec_mc.Contains("success"))
                    {
                        errorLbl.Text = "The discount code was sent to your mail (" + mail + ")";
                        errorLbl.ForeColor = Color.FromArgb(255, 70, 233, 72);
                    }

                    break;
                case "Team Fortress 2":
                    string url_tf2 = "https://teaclient.com/api/checkpromo.php?username=" + username + "&password=" + password + "&type=tf2";
                    string rec_tf2 = new WebClient().DownloadString(url_tf2);

                    if(rec_tf2.Contains("not_found"))
                    {
                        errorLbl.Text = "The username was not found.";
                        errorLbl.ForeColor = Color.Firebrick;
                    }

                    if (rec_tf2.Contains("already"))
                    {
                        errorLbl.Text = "You already recieved the discount code on your mail.";
                        errorLbl.ForeColor = Color.Firebrick;
                    }

                    if (rec_tf2.Contains("success"))
                    {
                        errorLbl.Text = "The discount code was sent to your mail (" + mail + ")";
                        errorLbl.ForeColor = Color.FromArgb(255, 70, 233, 72);
                    }
                    break;
            }
            return "Something went wrong. Please try again later!";
        }

        private string encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(username.Text.Length != 0)
            {
                getStatus(Login.storedUsername, encode(Login.storedPassword));
            }
            else
            {
                errorLbl.Text = "Username field cannot be blank.";
            }
        }
    }
}
