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
    public partial class OwnerCardForm : Form
    {
        PetContext db;
        //private Owner Own;

        public OwnerCardForm(Owner owner)
        {
            InitializeComponent();

            db = new PetContext();
            db.Pets.Load();

            petDataGridView.DataSource = db.Pets.Local.ToBindingList(); 
            
        }


        //insert pet
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //PetB pt = new PetB();
            //pt.PetInsert();

            PetCardForm dc = new PetCardForm();
            DialogResult result = dc.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            Pet pet = new Pet();
            pet.Name = dc.nameTextBox1.Text;
            pet.Sex = dc.sexComboBox.Text;
            pet.Birthday = dc.birthdayTextBox.Text;
            pet.Species = dc.speciesTextBox.Text;
            pet.BreedType = dc.breedTypeTextBox.Text;
            pet.Colour = dc.colourTextBox.Text;
            pet.OwnerID = int.Parse(ownerIDTextBox.Text);

            db.Pets.Add(pet);
            db.SaveChanges();
        }

        //update pet
        public void PetUpdate()
        {
            if (petDataGridView.SelectedRows.Count > 0)
            {
                int index = petDataGridView.SelectedRows[0].Index;
                int PetId = 0;
                bool converted = Int32.TryParse(petDataGridView[0, index].Value.ToString(), out PetId);
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
                petDataGridView.Refresh();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PetUpdate();
        }

        //open pet from
        private void petDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PetUpdate();
        }

        //delete pet
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (petDataGridView.SelectedRows.Count > 0)
            {
                int index = petDataGridView.SelectedRows[0].Index;
                int PetId = 0;
                bool converted = Int32.TryParse(petDataGridView[0, index].Value.ToString(), out PetId);
                if (converted == false)
                    return;

                Pet pet = db.Pets.Find(PetId);
                db.Pets.Remove(pet);
                db.SaveChanges();

                MessageBox.Show("Питомец удалён");
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //Photo.PhotoAttachment(PathToFile.Text, pictureBox1);

            int id = Photo.PhotoAttachment(PathToFile.Text, pictureBox1);

            using (var context = new OwnerContext())
            {
                int owid = int.Parse(this.ownerIDTextBox.Text);

                Owner owner = context.Owners.Single(own => own.OwnerId == owid);
                owner.Photo = id;
                context.SaveChanges();
            }
        }
    }
}
