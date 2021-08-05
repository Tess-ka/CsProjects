using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinicApp
{
    public partial class OwnerCardForm : Form
    {
        public OwnerCardForm()
        {
            InitializeComponent();
        }

        private void OwnerCardForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBVetClinicaDataSet.Pet' table. You can move, or remove it, as needed.
            this.petTableAdapter.Fill(this.dBVetClinicaDataSet.Pet);

        }
    }
}
