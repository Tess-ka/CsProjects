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
    public partial class TreatmentCaseForm : Form
    {
        public TreatmentCaseForm()
        {
            InitializeComponent();
        }

        private void TreatmentCaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBVetClinicaDataSet.Service' table. You can move, or remove it, as needed.
            this.serviceTableAdapter.Fill(this.dBVetClinicaDataSet.Service);

        }
    }
}
