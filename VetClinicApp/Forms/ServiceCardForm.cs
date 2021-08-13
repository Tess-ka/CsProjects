using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinicApp.Forms
{
    public partial class ServiceCardForm : Form
    {
        public ServiceCardForm()
        {
            InitializeComponent();
        }

        private void serviceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBVetClinicaDataSet);

        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBVetClinicaDataSet.Service' table. You can move, or remove it, as needed.
            this.serviceTableAdapter.Fill(this.dBVetClinicaDataSet.Service);

        }
    }
}
