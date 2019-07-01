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
using Newtonsoft;
using System.Xml;
using System.Xml.Linq;

namespace TeaClientLauncher
{
    public partial class City : MetroForm
    {
        public City()
        {
            InitializeComponent();
        }

        private void City_Load(object sender, EventArgs e)
        {
            string ipAddr = new WebClient().DownloadString("https://api.ipify.org/");

            string api = new WebClient().DownloadString("http://www.geoplugin.net/xml.gp?ip=" + ipAddr);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(api);
            XmlElement optional = doc.SelectSingleNode(@"/geoPlugin/geoplugin_city") as XmlElement;
            string city = optional.InnerText;


            ipLbl.Text = "Is " + ipAddr + " your IP address?";
            cityLbl.Text = "Is " + city + " your City?";
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if(read.Checked)
            {
                string api = new WebClient().DownloadString("http://www.geoplugin.net/xml.gp?ip=" + new WebClient().DownloadString("https://api.ipify.org/"));
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(api);
                XmlElement optional = doc.SelectSingleNode(@"/geoPlugin/geoplugin_city") as XmlElement;
                string city = optional.InnerText;
                updateCity(new WebClient().DownloadString("https://api.ipify.org/"), city);
            }
            else
            {
                errorLbl.Text = "You need to agree with our terms \nwritten on this page to proceed.";
            }
        }

        private void updateCity(string ip, string city)
        {
            string response = new WebClient().DownloadString("https://teaclient.com/api/setipandcountry.php?username=" + Login.storedUsername + "&password=" + encode(Login.storedPassword) + "&ip=" + ip + "&city=" + city);

            if(response.Contains("true"))
            {
                Login login = new Login("Please login again.");
                this.Hide();
                login.Show();
            }
            else if(response.Contains("error"))
            {
                errorLbl.Text = "There was an error while updating the city. Please try again later.";
            }
        }

        private string encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
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
