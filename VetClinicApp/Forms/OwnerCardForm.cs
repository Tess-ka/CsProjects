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
        //OwnerContext bd;

        public OwnerCardForm()
        {
            InitializeComponent();

            db = new PetContext();
            db.Pets.Load();

            GridPet();

            //bd = new OwnerContext();
            //bd.Owners.Load();

            petDataGridView.DataSource = db.Pets.Local.ToBindingList();

            //using (PetContext pc = new PetContext())
            //{
            //    var pets = pc.Pets.Where(p => p.OwnerID.Value.ToString() == ownerIDTextBox.Text);
            //    foreach (Pet p in pets)


            //}
        }

        public void GridPet()
        {

            //PetContext pt = new PetContext();
            //BindingSource b = new BindingSource();
            //string OwnerID = ownerIDTextBox.Text;

            //b.DataSource = from Pet in pt.Pets
            //               where Pet.OwnerID == int.Parse(ownerIDTextBox.Text)
            //               select Pet;
            //petDataGridView.DataSource = b;


            //var query = from DataGridViewRow row in petDataGridView.Rows
            //            where row.Cells["petIdDataGridViewTextBoxColumn"].Value.ToString() == OwnerID
            //            select row;
            //DataGridViewRow result = query.FirstOrDefault();

            using (PetContext pt = new PetContext())
            {
                var q = from p in pt.Pets
                        where p.OwnerID == int.Parse(ownerIDTextBox.Text)
                        select p;

                //petDataGridView.DataSource = q;

            }



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
    }
}
