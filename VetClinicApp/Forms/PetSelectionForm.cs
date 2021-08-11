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
    public partial class PetSelectionForm : Form
    {
        PetContext db;
        public PetSelectionForm()
        {
            InitializeComponent();

            db = new PetContext();
            db.Pets.Load();

            petSelectionGridView.DataSource = db.Pets.Local.ToBindingList();
        }


        private void petDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //отправка выбранного питомца на форму поиска

            if (petSelectionGridView.SelectedRows.Count > 0)
            {
                int index = petSelectionGridView.SelectedRows[0].Index;
                int PetId = 0;
                bool converted = Int32.TryParse(petSelectionGridView[0, index].Value.ToString(), out PetId);
                if (converted == false)
                    return;

                Pet pet = db.Pets.Find(PetId);

            }
        }
    }
}
