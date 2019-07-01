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
using System.Net;

namespace TeaClientLauncher
{
    public partial class OrderID : MetroForm
    {
        private bool _mc;
        private bool _tf2;
        public OrderID(bool mc, bool tf2)
        {
            InitializeComponent();
            _mc = mc;
            _tf2 = tf2;
        }

        private bool hasMC()
        {
            return _mc;
        }

        private bool hasTF2()
        {
            return _tf2;
        }

        private void OrderID_Load(object sender, EventArgs e)
        {
            if(!hasMC())
            {
                mcenter.Visible = true;
                orderidmc.Visible = true;
            }

            if (!hasTF2())
            {
                tf2enter.Visible = true;
                orderidtf2.Visible = true;
            }

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if(!hasMC() && orderidmc.Text == "")
            {
                errorLbl.Text = "Order-ID can't be blank!";
                return;
            }

            if(!hasMC())
            {
                checkMC(orderidmc.Text);
            }

            if (!hasTF2() && orderidtf2.Text == "")
            {
                errorLbl2.Text = "Order-ID can't be blank!";
                return;
            }

            if (!hasTF2())
            {
                checkTF2(orderidtf2.Text);
            }
        }

        private void checkMC(string orderid)
        {
            string response = new WebClient().DownloadString("https://teaclient.com/api/check.php?username=" + Login.storedUsername + "&password=" + encode(Login.storedPassword) + "&orderid=" + orderid);


            if(response.Contains("true"))
            {
                Login tea = new Login("Please login again.");
                this.Hide();
                tea.Show();
            }else if(response.Contains("error"))
            {
                errorLbl.Text = "An error occurred while doing operation. Please try again later.";
            }
            else
            {
                errorLbl.Text = "Invalid Order-ID";
            }
        }

        private void checkTF2(string orderid)
        {
            string response = new WebClient().DownloadString("https://teaclient.com/api/checktf2.php?username=" + Login.storedUsername + "&password=" + encode(Login.storedPassword) + "&orderid=" + orderid);

            if (response.Contains("true"))
            {
                Login tea = new Login("Please login again.");
                this.Hide();
                tea.Show();
            }
            else if (response.Contains("error"))
            {
                errorLbl2.Text = "An error occurred while doing operation. Please try again later.";
            }
            else
            {
                errorLbl2.Text = "Invalid Order-ID";
            }
        }

        private string encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
