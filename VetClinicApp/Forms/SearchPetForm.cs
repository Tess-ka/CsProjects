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
    public partial class SearchPetForm : Form
    {
        public SearchPetForm()
        {
            InitializeComponent();
        }

        private void petBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.petBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBVetClinicaDataSet);

        }

        private void SearchPetForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBVetClinicaDataSet.TreatmentСase' table. You can move, or remove it, as needed.
            this.treatmentСaseTableAdapter.Fill(this.dBVetClinicaDataSet.TreatmentСase);
            // TODO: This line of code loads data into the 'dBVetClinicaDataSet.Owner' table. You can move, or remove it, as needed.
            this.ownerTableAdapter.Fill(this.dBVetClinicaDataSet.Owner);
            // TODO: This line of code loads data into the 'dBVetClinicaDataSet.Pet' table. You can move, or remove it, as needed.
            this.petTableAdapter.Fill(this.dBVetClinicaDataSet.Pet);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.petTableAdapter.FillBy(this.dBVetClinicaDataSet.Pet, ((int)(System.Convert.ChangeType(petIdToolStripTextBox.Text, typeof(int)))), nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button_cardpet_open_Click(object sender, EventArgs e)
        {
            PetCardForm newForm = new PetCardForm(this);
            newForm.Show();
        }

        private void button_cardpet_open_new_Click(object sender, EventArgs e)
        {
            PetCardForm newForm = new PetCardForm(this);
            newForm.Show();
        }

        private void button_search_owner_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //using (SqlConnection )
            //}
        }
    }
}
