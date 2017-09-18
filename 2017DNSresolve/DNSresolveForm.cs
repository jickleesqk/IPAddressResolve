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
using System.Net.Sockets;
using _2017DNSresolve;

namespace _2017DNSresolve
{
    public partial class DNSresolveForm : Form
    {
        public DNSresolveForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPHostEntry iphe;
            iphe = Dns.GetHostEntry();
            int i;
            i = inputbox.Text.Length;
            if (i != 0)
            {
                hostbox.Text.IndexOf(iphe.HostName);
                foreach (IPAddress ipa in iphe.AddressList)
                {
                    ipbox.Text.ToString(ipa.ToString() + "\n\t\t");
                }
                foreach (string alias in iphe.Aliases)
                {
                    Aliasbox.Text.ToString(alias + "\n\t\t");
                }
            }
        }

        private void DNSresolveForm_Load(object sender, EventArgs e)
        {

        }

        private void inputbox_TextChanged(object sender, EventArgs e)
        {
            
        }


    }
}
