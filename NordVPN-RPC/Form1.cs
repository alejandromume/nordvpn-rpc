using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using DiscordRPC;
using System.Diagnostics;
using Newtonsoft.Json;
using IpInfo;
using System.Globalization;
using System.Collections.Specialized;

namespace NordVPN_RPC
{
    public partial class Form1 : Form
    {

        public DiscordRpcClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*string hostName = Dns.GetHostName();
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            gunaTextBox1.Text = myIP;*/


        }

        private void gunaGoogleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaGoogleSwitch1.Checked == true)
            {
                String address = "";
                WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
                using (WebResponse response = request.GetResponse())
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    address = stream.ReadToEnd();
                }

                int first = address.IndexOf("Address: ") + 9;
                int last = address.LastIndexOf("</body>");
                address = address.Substring(first, last - first);

                gunaTextBox1.Text = address;

            }
            else
            {
                gunaTextBox1.Text = "";

            }
        }

        private void gunaMediumCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaMediumCheckBox3.Checked == true)
            {
                gunaMediumCheckBox1.Checked = true;
                gunaMediumCheckBox1.Enabled = false;
                gunaMediumCheckBox2.Checked = true;
                gunaMediumCheckBox2.Enabled = false;
                gunaGoogleSwitch1.Checked = true;
                gunaGoogleSwitch1.Enabled = false;
            }
            else
            {
                gunaMediumCheckBox1.Checked = false;
                gunaMediumCheckBox1.Enabled = true;
                gunaGoogleSwitch1.Checked = false;
                gunaGoogleSwitch1.Enabled = true;
                gunaMediumCheckBox2.Checked = false;
                gunaMediumCheckBox2.Enabled = true;
            }
        }
        public class IpInfo
        {
            [JsonProperty("ip")]
            public string Ip { get; set; }

            [JsonProperty("hostname")]
            public string Hostname { get; set; }

            [JsonProperty("city")]
            public string City { get; set; }

            [JsonProperty("region")]
            public string Region { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("loc")]
            public string Loc { get; set; }

            [JsonProperty("org")]
            public string Org { get; set; }

            [JsonProperty("postal")]
            public string Postal { get; set; }
            
            [JsonProperty("vpn")]
            public bool VPN { get; set; }
        }

        private Timer timer1;

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startRPC();
        }
        public string checkIp()
        {
            string id = "798283015545028630";
            string country;
            string city;

            String address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }

            int first = address.IndexOf("Address: ") + 9;
            int last = address.LastIndexOf("</body>");
            address = address.Substring(first, last - first);

            return address;
            
        }
        
        public string checkCountry()
        {
            string country;
            IpInfo ipInfo = new IpInfo();
            gunaProgressBar1.Value = 35;
            string info = new WebClient().DownloadString("http://ipinfo.io/" + checkIp());
            ipInfo = JsonConvert.DeserializeObject<IpInfo>(info);
            RegionInfo myRI1 = new RegionInfo(ipInfo.Country);
            ipInfo.Country = myRI1.EnglishName;
            country = ipInfo.Country;

            return country;

        }

        public string checkCity()
        {

            string city;
            IpInfo ipInfo = new IpInfo();
            gunaProgressBar1.Value = 50;

            string info = new WebClient().DownloadString("http://ipinfo.io/" + checkIp());
            ipInfo = JsonConvert.DeserializeObject<IpInfo>(info);
            RegionInfo myRI1 = new RegionInfo(ipInfo.Country);
            ipInfo.Country = myRI1.EnglishName;
            city = ipInfo.City;


            return city;
        }

        public bool CheckVPN()
        {

            string url = $"https://ipqualityscore.com/api/json/ip/tMTaQwK5wLcJdwqDCAeRI2qgsPYPmlRY/{checkIp()}";
            IpInfo ipInfo = new IpInfo();
            string info = new WebClient().DownloadString(url);
            ipInfo = JsonConvert.DeserializeObject<IpInfo>(info);
            gunaProgressBar1.Value = 35;
            if (ipInfo.VPN)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void gunaMediumCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            /*if(gunaMediumCheckBox2.Checked == true)
            {
                gunaGoogleSwitch1.Checked = true;
                gunaGoogleSwitch1.Enabled = false;
            }
            else
            {
                gunaGoogleSwitch1.Checked = false;
                gunaGoogleSwitch1.Enabled = true;
            }*/
        }

        public void startRPC()
        {

            gunaGoogleSwitch1.Enabled = false;
            gunaMediumCheckBox1.Enabled = false;
            gunaMediumCheckBox3.Enabled = false;
            gunaMediumCheckBox2.Enabled = false;

            string id = "798283015545028630";

            client = new DiscordRpcClient(id);
            client.Initialize();
            gunaProgressBar1.Value = 25;
            client.SetPresence(new RichPresence()
            {
                Details = "Connected",
                //State = $"{checkCountry()} ({checkCity()})",
                Timestamps = (gunaMediumCheckBox1.Checked == true ? new Timestamps() { Start = DateTime.UtcNow, End = null } : null),
                Assets = new Assets()
                {
                    LargeImageKey = "juf1ibzv_400x400_1_",
                    LargeImageText = (gunaMediumCheckBox2.Checked == true ? $"{checkCountry()} ({checkCity()})" : (gunaGoogleSwitch1.Checked == true ? checkIp() : "")),
                    SmallImageKey = "info3",
                    SmallImageText = "Owner: alejandromume#0884"

                }
            });

            gunaProgressBar1.Value = 100;
            pictureBox1.BackColor = Color.MediumSpringGreen;
        }

        public void startConnection()
        {
            Process[] pname = Process.GetProcessesByName("NordVPN");
            Process[] pname2 = Process.GetProcessesByName("Discord");

            if (pname.Length == 0)
            {
                MessageBox.Show("NordVPN is not running!");
            }
            else
            {
                if(pname2.Length == 0)
                {
                    MessageBox.Show("Discord is not running!");

                }
                else
                {
                    if (!CheckVPN())
                    {
                        MessageBox.Show("You must be connected to a NordVPN connection!");
                    }
                    else
                    {
                        startRPC();
                    }
                }
                
            }

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            startConnection();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            client.Dispose();
            pictureBox1.BackColor = Color.Red;
            gunaGoogleSwitch1.Enabled = true;
            gunaMediumCheckBox1.Enabled = true;
            gunaMediumCheckBox3.Enabled = true;
            gunaMediumCheckBox2.Enabled = true;
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaMediumCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaMediumCheckBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startConnection();
        }

        private void stopRPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client.Dispose();
            pictureBox1.BackColor = Color.Red;
            gunaGoogleSwitch1.Enabled = true;
            gunaMediumCheckBox1.Enabled = true;
            gunaMediumCheckBox3.Enabled = true;
            gunaMediumCheckBox2.Enabled = true;
        }
    }
}
