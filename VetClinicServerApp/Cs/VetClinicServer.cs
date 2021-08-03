using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace VetClinicServerApp
{
    class VetClinicServer
    {
        static void Main(string[] args)
        {
            StarterServer starter = new StarterServer();
            starter.Start();

        }
    }
}
