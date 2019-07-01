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
using System.Security.Cryptography;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using TeaClientLauncher.Properties;

namespace TeaClientLauncher
{
    public partial class Login : MetroForm
    {
        public static string storedUsername;
        public static string storedPassword;

        public static string purchased_tf2;
        public static string purchased_mc;
        public static string purchased_mcv3;

        private string _status = "";

        public Login(string status)
        {
            InitializeComponent();
            Focus();
            username.Focus();
            _status = status;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            errorLbl.Text = _status;
            if (File.Exists(@"c:\Tea\launcher\login\credenticals.txt"))
            {
                string[] content = System.IO.File.ReadAllText(@"c:\Tea\launcher\login\credenticals.txt").Split(':');
                username.Text = content[0];
                password.Text = decode(content[1]);
                keepLoggedIn.Checked = true;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            errorLbl.Text = "";
            if(username.Text == "" || password.Text == "")
            {
                errorLbl.Text = "The username and password field cannot be blank.";
                return;
            }

            login(username.Text, password.Text);

        }

        private void login(string username, string password)
        {
            string response = new WebClient().DownloadString("https://teaclient.com/api/clientlogin.php?username=" + username + "&password=" + encode(password));

            /*if (response.Contains("truebutorderid"))
            {
                string[] data = response.Split(':');
                storedUsername = username;
                storedPassword = password;
                OrderID order = new OrderID(data[1] != "null" ? true : false, data[2].Replace("</pre>", "") != "null" ? true : false);
                this.Hide();
                order.Show();
            }*/
            if (response.Contains("truebutip"))
            {
                storedUsername = username;
                storedPassword = password;
                City city = new City();
                this.Hide();
                city.Show();
            }
            else if (response.Contains("true"))
            {
                string[] data = response.Split(':');
                purchased_mc = data[1];
                purchased_mcv3 = data[2];
                purchased_tf2 = data[3];
                storedUsername = username;
                storedPassword = password;

                if (keepLoggedIn.Checked)
                {
                    if (!File.Exists(@"c:\Tea\launcher\login\credenticals.txt"))
                    {
                        //File.CreateText(@"c:\Tea\launcher\login\credenticals.txt");
                        File.WriteAllText(@"c:\Tea\launcher\login\credenticals.txt", username + ":" + encode(password));
                    }
                }
                else
                {
                    if (File.Exists(@"c:\Tea\launcher\login\credenticals.txt"))
                    {
                        File.Delete(@"c:\Tea\launcher\login\credenticals.txt");
                    }
                }

                Tea tea = new Tea();
                this.Hide();
                tea.Show();
            }
            else
            {
                errorLbl.Text = "Invalid username or password";
            }
        }

        /*public void login(string username, string password)
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
                        byte[] msg = Encoding.ASCII.GetBytes("client_login:" + username + ":" + encode(password));

                        // Send the data through the socket.    
                        int bytesSent = sender.Send(msg);

                        // Receive the response from the remote device.    
                        int bytesRec = sender.Receive(bytes);
                        //Console.WriteLine("Echoed test = {0}",
                        //    Encoding.ASCII.GetString(bytes, 0, bytesRec));

                        Console.WriteLine(Encoding.ASCII.GetString(bytes, 0, bytesRec));

                        if (Encoding.ASCII.GetString(bytes, 0, bytesRec).Contains("true"))
                        {
                            string[] data = Encoding.ASCII.GetString(bytes, 0, bytesRec).Split(':');
                            storedUsername = username;
                            storedPassword = password;
                            purchased_mc = data[1].ToString();
                            purchased_tf2 = data[2].ToString();
                            if (keepLoggedIn.Checked)
                            {
                                if (!File.Exists(@"c:\Tea\launcher\login\credenticals.txt"))
                                {
                                    //File.Create(@"c:\Tea\launcher\login\credenticals.txt");
                                    using (StreamWriter writer = new StreamWriter(@"c:\Tea\launcher\login\credenticals.txt"))
                                    {
                                        writer.WriteLine(username);
                                        writer.WriteLine(encode(password));
                                    }
                                }
                            }
                            else
                            {
                                if (File.Exists(@"c:\Tea\launcher\login\credenticals.txt"))
                                {
                                    File.Delete(@"c:\Tea\launcher\login\credenticals.txt");
                                }
                            }

                            Tea tea = new Tea();
                            this.Hide();
                            tea.Show();

                        }
                        else
                        {
                            errorLbl.Text = "Invalid username or password.";
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

        private int? ConvertStringToInt(string intString)
        {
            int i = 0;
            return (Int32.TryParse(intString, out i) ? i : (int?)null);
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
    }
}
