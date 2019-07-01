using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace TeaClientLauncher.Properties
{
    public partial class TeaMC : MetroForm
    {
        private string _title;
        private double _price;
        private bool _purchased;

        bool hasAuthority;

        public TeaMC(string title, double price, bool purchased)
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
            title.Text = getTitle();
            price.Text = getPrice().ToString() + "$";

            license_button.Visible = false;

            if (isPurchased())
            {
                price.Text = "Owned";
                currencyLbl.Visible = false;
                currency.Visible = false;
                license_button.Visible = false;

                launch_or_purchase_button.Text = "Launch";
                hasAuthority = true;
            }
            else
            {
                launch_or_purchase_button.Text = "Not Available";
            }

            BringToFront();
            Activate();
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
            /*License license = new License(getTitle());
            this.Hide();
            license.Show();*/
        }

        private void discount_Click(object sender, EventArgs e)
        {
            
        }
    }
}
