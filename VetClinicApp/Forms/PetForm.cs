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


        private void petGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (petGridView.SelectedRows.Count > 0)
            {
                int index = petGridView.SelectedRows[0].Index;
                int PetId = 0;
                bool converted = Int32.TryParse(petGridView[0, index].Value.ToString(), out PetId);
                if (converted == false)
                    return;

                Pet pet = db.Pets.Find(PetId);
                PetCardForm dc = new PetCardForm(pet);

                db.SaveChanges();
                petGridView.Refresh();
            }
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
