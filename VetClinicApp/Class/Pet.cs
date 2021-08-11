using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace VetClinicApp
{
    public class PetB
    {
        PetContext db;

        public void PetInsert()
        {
            db = new PetContext();
            db.Pets.Load();

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

            db.Pets.Add(pet);
            db.SaveChanges();
        }

    }

}

