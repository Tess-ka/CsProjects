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
using System.IO;

namespace VetClinicServerApp
{
    public partial class ConnectForm : Form

    {
       
        public ConnectForm()
        {
            InitializeComponent();

        }

        static void Main(string[] args)
        {
            VetClinicServer starter = new VetClinicServer();
            starter.ServerApp();

        }
        private void ConnectButton_Click(object sender, EventArgs e)   //Start server
        {
            VetClinicServer starter = new VetClinicServer();
            starter.ServerApp();

        }
    }
}
