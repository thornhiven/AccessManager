using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSTSCLib;
    
namespace AccessManager
{
    public partial class MainForm : Form
    {
        public List<Client> clients = new List<Client>();
        public String

        public MainForm()
        {
            InitializeComponent();
            

            Client cl = new Client();
            cl.name = "test";
            cl.fullName = "Full name client test";

            var rdp = new MSTSCLib.MsRdpClient8();


            //clients.Add(cl);

            //listView1.Items.Add(clients);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            listView1.Width = (int)this.Width / 3;
            listView1.Height = (int)this.Height - 70;
        }
    }
}
