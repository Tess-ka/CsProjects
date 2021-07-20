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
    public partial class PetCardForm : Form
    {
        public PetCardForm(SearchPetForm f)
        {
            InitializeComponent();
        }

        private void PetCardForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBVetClinicaDataSet.Pet' table. You can move, or remove it, as needed.
            this.petTableAdapter.Fill(this.dBVetClinicaDataSet.Pet);

        }

        private void petBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.petBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBVetClinicaDataSet);

        }
    }
}
