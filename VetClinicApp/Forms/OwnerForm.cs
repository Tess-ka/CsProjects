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
    public partial class OwnerForm : Form
    {
        OwnerContext db;
        ImagesContext ic;
        public OwnerForm()
        {
            InitializeComponent();

            db = new OwnerContext();
            db.Owners.Load();

            ic = new ImagesContext();
            ic.Images.Load();


            ownerDataGridView.DataSource = db.Owners.Local.ToBindingList();
        }

        //insert Owner
        private void InsertButton_Click(object sender, EventArgs e)
        {
            Owner owner = new Owner();
            OwnerCardForm dc = new OwnerCardForm(null);
            DialogResult result = dc.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            db.Owners.Add(dc.GetOwner);
            db.SaveChanges();
        }

        //open Owner
        private void ownerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ownerDataGridView.SelectedRows.Count > 0)
            {
                int index = ownerDataGridView.SelectedRows[0].Index;
                int OwnerId = 0;
                bool converted = Int32.TryParse(ownerDataGridView[0, index].Value.ToString(), out OwnerId);
                if (converted == false)
                    return;

                Owner owner = db.Owners.Find(OwnerId);
                OwnerCardForm dc = new OwnerCardForm(owner);

                db.SaveChanges();
                ownerDataGridView.Refresh();
            }
        }

        //delete Owner
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ownerDataGridView.SelectedRows.Count > 0)
            {
                int index = ownerDataGridView.SelectedRows[0].Index;
                int OwnerId = 0;
                bool converted = Int32.TryParse(ownerDataGridView[0, index].Value.ToString(), out OwnerId);
                if (converted == false)
                    return;

                Owner owner = db.Owners.Find(OwnerId);
                db.Owners.Remove(owner);
                db.SaveChanges();

                MessageBox.Show("Владелец удалён");
            }
        }
    }
}
