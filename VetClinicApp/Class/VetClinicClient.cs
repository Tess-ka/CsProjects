using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace VetClinicApp
{
    internal class VetClinicClient
    {
        [STAThread]
        static void Main(string[] args)
        {
            Starter starter = new Starter();
            starter.Start();

            starter.InitConnection();
        }
    }
}
