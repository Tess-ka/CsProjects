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
    public partial class OwnerForm : Form
    {
        public OwnerForm()
        {
            InitializeComponent();
        }

        //private void richTextBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void ownerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ownerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBVetClinicaDataSet);

        }

        private void OwnerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBVetClinicaDataSet.Owner' table. You can move, or remove it, as needed.
            this.ownerTableAdapter.Fill(this.dBVetClinicaDataSet.Owner);

        }

        private void searchOwnerToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ownerTableAdapter.SearchOwner(this.dBVetClinicaDataSet.Owner, lastNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
