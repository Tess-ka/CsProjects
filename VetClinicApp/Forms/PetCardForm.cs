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
    public partial class PetCardForm : Form
    {
        OwnerContext oc;
        ImagesContext ic;

        private Pet Pet;

        //public PetCardForm(SearchPetForm f)
        //{
        //    InitializeComponent();
        //}

        public PetCardForm(Pet pet)
        {
            InitializeComponent();

            oc = new OwnerContext();
            oc.Owners.Load();

            ic = new ImagesContext();
            ic.Images.Load();

            if (pet == null)
            {
                Pet = new Pet();
                sexComboBox.SelectedIndex = 0;

                //хотела предзаполнить поля с владельцем - не работает

                //OwnerCardForm main = this.Owner as OwnerCardForm;
                //if (main != null)
                //{
                //    this.ownerIDLabel1.Text = main.ownerIDTextBox.Text;
                //    this.FIOOwnerlabel.Text = $"{main.lastNameTextBox} {main.firstNameTextBox} {main.fatherNameTextBox}";
                //}
            }
            else
            {
                Pet = pet;
                this.petIdTextBox1.Text = pet.PetId.ToString();
                this.nameTextBox1.Text = pet.Name;
                this.sexComboBox.Text = pet.Sex;
                this.birthdayTextBox.Text = pet.Birthday;
                this.speciesTextBox.Text = pet.Species;
                this.breedTypeTextBox.Text = pet.BreedType;
                this.colourTextBox.Text = pet.Colour;
                this.ownerIDLabel1.Text = pet.OwnerID.ToString();
                this.FIOOwnerlabel.Text = $"{pet.Owner.LastName} {pet.Owner.FirstName} {pet.Owner.FatherName}";

                var d = from im in ic.Images
                        where im.Id == pet.Photo
                        select im.Path;
                var imm = d.FirstOrDefault();

                if (imm != null)
                {
                    this.pictureBox2.Image = new Bitmap(imm);
                    this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                }

                DialogResult result = ShowDialog();
                if (result == DialogResult.Cancel)
                    return;
            }
        }

        public Pet GetPet => this.Pet;

        protected override void OnClosing(CancelEventArgs e)
        {
            if (!e.Cancel)
            {
                Pet.Name = this.nameTextBox1.Text;
                Pet.Sex = this.sexComboBox.Text;
                Pet.Birthday = this.birthdayTextBox.Text;
                Pet.Species = this.speciesTextBox.Text;
                Pet.BreedType = this.breedTypeTextBox.Text;
                Pet.Colour = this.colourTextBox.Text;

                OwnerCardForm main = this.Owner as OwnerCardForm;
                if (main != null)
                {
                    Pet.OwnerID = int.Parse(main.ownerIDTextBox.Text);
                }
            }
            base.OnClosing(e);
        }

        //Открытие формы владельца
        private void FIOOwnerlabel_Click(object sender, EventArgs e)
        {

        }

        //Добавление фото
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.petIdTextBox1.Text == "")
            {
                MessageBox.Show("Сохраните данные");
            }
            else
            {
                int id = Photo.PhotoAttachment(label3.Text, pictureBox2);

                using (var context = new PetContext())
                {
                    int Petid = int.Parse(this.petIdTextBox1.Text);

                    Pet pet = context.Pets.Single(pt => pt.PetId == Petid);
                    pet.Photo = id;
                    context.SaveChanges();
                }
            }
        }
    }
}
