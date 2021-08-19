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
    public partial class PetForm : Form
    {
        PetContext db;

        public PetForm()
        {
            InitializeComponent();

            db = new PetContext();
            db.Pets.Load();

            petGridView.DataSource = db.Pets.Local.ToBindingList();
        }

        public void PetUpdate()
        {
            if (petGridView.SelectedRows.Count > 0)
            {
                int index = petGridView.SelectedRows[0].Index;
                int PetId = 0;
                bool converted = Int32.TryParse(petGridView[0, index].Value.ToString(), out PetId);
                if (converted == false)
                    return;

                Pet pet = db.Pets.Find(PetId);

                PetCardForm dc = new PetCardForm();

                dc.petIdTextBox1.Text = pet.PetId.ToString();
                dc.nameTextBox1.Text = pet.Name;
                dc.sexComboBox.Text = pet.Sex;
                dc.birthdayTextBox.Text = pet.Birthday;
                dc.speciesTextBox.Text = pet.Species;
                dc.breedTypeTextBox.Text = pet.BreedType;
                dc.colourTextBox.Text = pet.Colour;
                dc.ownerIDLabel1.Text = pet.OwnerID.ToString();

                DialogResult result = dc.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                pet.Name = dc.nameTextBox1.Text;
                pet.Sex = dc.sexComboBox.Text;
                pet.Birthday = dc.birthdayTextBox.Text;
                pet.Species = dc.speciesTextBox.Text;
                pet.BreedType = dc.breedTypeTextBox.Text;
                pet.Colour = dc.colourTextBox.Text;

                db.SaveChanges();
                petGridView.Refresh();
            }
        }

        private void petGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PetUpdate();
        }

        private void UpdateStripButton_Click_1(object sender, EventArgs e)
        {
            PetUpdate();
        }

        private void DeleteStripButton_Click_1(object sender, EventArgs e)
        {
            if (petGridView.SelectedRows.Count > 0)
            {
                int index = petGridView.SelectedRows[0].Index;
                int PetId = 0;
                bool converted = Int32.TryParse(petGridView[0, index].Value.ToString(), out PetId);
                if (converted == false)
                    return;

                Pet pet = db.Pets.Find(PetId);
                db.Pets.Remove(pet);
                db.SaveChanges();

                MessageBox.Show("Питомец удалён");
            }
        }
    }
}
