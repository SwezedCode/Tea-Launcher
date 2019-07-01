using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using TeaClientLauncher.Properties;

namespace TeaClientLauncher
{
    public partial class License : MetroForm
    {
        string _productName;

        public License(string productName)
        {
            InitializeComponent();
            _productName = productName;
        }

        private string getProcuctName()
        {
            return _productName;
        }

        private void License_Load(object sender, EventArgs e)
        {
            licenseheader.Text = "Redeem license for " + getProcuctName();
            BringToFront();
            Activate();
        }

        private void activatebutton_Click(object sender, EventArgs e)
        {
            if(licenseinput.Text == "")
            {
                errorLbl.Text = "The license cannot be blank";
                return;
            }

            redeemLicense(licenseinput.Text);

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Product minecraft = new Product("Minecraft - v3", Convert.ToDouble(new WebClient().DownloadString("https://teaclient.com/api/price.txt").ToString().Split(':')[2]), Login.purchased_mcv3.ToString().Contains("1") ? true : false);
            //Product tf2 = new Product("Team Fortress 2", Convert.ToDouble(new WebClient().DownloadString("https://teaclient.com/api/price.txt").ToString().Split(':')[1]), Login.purchased_tf2.ToString().Contains("1") ? true : false);
            switch (getProcuctName())
            {
                case "Minecraft - v3":
                    TeaMCv3 mc = new TeaMCv3(minecraft.getName(), minecraft.getPrice(), minecraft.isPurchased());
                    this.Hide();
                    mc.Show();
                    break;
                case "Team Fortress 2":
                    /*TeaTF2 tf = new TeaTF2(tf2.getName(), tf2.getPrice(), tf2.isPurchased());
                    this.Hide();
                    tf.Show();*/
                    break;
            }
        }

        private void redeemLicense(string license)
        {
            if(isOnline())
            {
                string response = "";

                switch(getProcuctName())
                {
                    case "Minecraft - v3":
                        response = new WebClient().DownloadString("https://teaclient.com/api/redeemlicense.php?username=" + Login.storedUsername + "&password=" + encode(Login.storedPassword) + "&license=" + license);
                        break;
                    case "Team Fortress 2":
                        //response = new WebClient().DownloadString("https://teaclient.com/api/redeemlicense_tf2.php?username=" + Login.storedUsername + "&password=" + encode(Login.storedPassword) + "&license=" + license);
                        break;
                }

                if(response.Contains("true"))
                {
                    Login login = new Login("Please login again.");
                    this.Hide();
                    login.Show();
                }else
                {
                    errorLbl.Text = "Invalid License";
                }
            }
        }

        /*public void redeem(string license, string orderid)
        {
            if (isOnline())
            {
                byte[] bytes = new byte[1024];

                try
                {
                    // Connect to a Remote server  
                    // Get Host IP Address that is used to establish a connection  
                    // In this case, we get one IP address of localhost that is IP : 127.0.0.1  
                    // If a host has multiple addresses, you will get a list of addresses  
                    //IPHostEntry host = Dns.GetHostEntry("199.19.225.12");
                    //IPAddress ipAddress = host.AddressList[0];
                    IPAddress ipAddress = IPAddress.Parse(decode("MTk5LjE5LjIyNS4xMg=="));
                    IPEndPoint remoteEP = new IPEndPoint(ipAddress, 1337);

                    // Create a TCP/IP  socket.    
                    Socket sender = new Socket(ipAddress.AddressFamily,
                        SocketType.Stream, ProtocolType.Tcp);

                    // Connect the socket to the remote endpoint. Catch any errors.    
                    try
                    {
                        // Connect to Remote EndPoint  
                        sender.Connect(remoteEP);

                        //Console.WriteLine("Socket connected to {0}",
                        //    sender.RemoteEndPoint.ToString());

                        // Encode the data string into a byte array.    
                        byte[] msg = { 0 };
                        if (getProcuctName() == "Minecraft")
                        {
                            msg = Encoding.ASCII.GetBytes("redeemlicense:" + Login.storedUsername + ":" + encode(Login.storedPassword.ToString()) + ":" + license + ":" + orderid);
                        }
                        else if(getProcuctName() == "Team Fortress 2")
                        {
                            msg = Encoding.ASCII.GetBytes("redeemlicense_tf2:" + Login.storedUsername + ":" + encode(Login.storedPassword.ToString()) + ":" + license + ":" + orderid);
                        }

                        // Send the data through the socket.    
                        int bytesSent = sender.Send(msg);

                        // Receive the response from the remote device.    
                        int bytesRec = sender.Receive(bytes);
                        //Console.WriteLine("Echoed test = {0}",
                        //    Encoding.ASCII.GetString(bytes, 0, bytesRec));

                        //Thread.Sleep(10000);

                        if (Encoding.ASCII.GetString(bytes, 0, bytesRec).Contains("true"))
                        {
                            Login login = new Login();
                            this.Hide();
                            login.Show();
                        }else if (Encoding.ASCII.GetString(bytes, 0, bytesRec).Contains("wrong"))
                        {
                            errorLbl.Text = "Invalid Order-ID";
                        }
                        else if (Encoding.ASCII.GetString(bytes, 0, bytesRec).Contains("invalid"))
                        {
                            errorLbl.Text = "Invalid License";
                        }

                        // Release the socket.    
                        sender.Shutdown(SocketShutdown.Both);
                        sender.Close();

                    }
                    catch (ArgumentNullException ane)
                    {
                        Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                        //displayMessage("[!]: ERROR DETECTED", "A unknwon error occurred, if the issue still remains please contact Swezed#4089 on discord.\nOutput: " + ane.ToString(), MessageBoxButtons.OK);
                        MessageBox.Show(null, "A unknown error occurred, if the issue still remains please contact Swezed#4089 on discord.\nOutput: " + ane.ToString(), "[!]: ERROR DETECTED");
                    }
                    catch (SocketException se)
                    {
                        //displayMessage("[!]: ERROR DETECTED", "There was a error contacting the servers! Please contact Swezed#4089 on discord if this error remains.\nOutput: " + se.ToString(), MessageBoxButtons.OK);
                        MessageBox.Show(null, "There was a error contacting the servers! Please contact Swezed#4089 on discord if this error remains.\nOutput: " + se.ToString(), "[!]: ERROR DETECTED");
                    }
                    catch (Exception e)
                    {
                        //displayMessage("[!]: ERROR DETECTED", "Something went wrong while logging in, please concider contacting Swezed#4089 on discord if the issue remains.\nOutput: " + e.ToString(), MessageBoxButtons.OK);
                        MessageBox.Show(null, "Something went wrong while logging in, please concider contacting Swezed#4089 on discord if the issue remains.\nOutput: " + e.ToString(), "[!]: ERROR DETECTED");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

        }*/

        private string encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private string decode(string plainText)
        {
            byte[] data = Convert.FromBase64String(plainText);
            return Encoding.UTF8.GetString(data);
        }

        private bool isOnline()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("https://teaclient.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
