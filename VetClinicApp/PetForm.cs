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
    public partial class PetForm : Form
    {
        public PetForm(MainFormVet f)
        {
            InitializeComponent();
        }

        private void petBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.petBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBVetClinicaDataSet);

        }

        private void PetForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBVetClinicaDataSet.Pet' table. You can move, or remove it, as needed.
            this.petTableAdapter.Fill(this.dBVetClinicaDataSet.Pet);

        }

        private void petIdSearchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.petTableAdapter.PetIdSearch(this.dBVetClinicaDataSet.Pet, ((int)(System.Convert.ChangeType(petIdToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void petBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
