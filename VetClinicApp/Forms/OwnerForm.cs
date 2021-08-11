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

        public OwnerForm()
        {
            InitializeComponent();

            db = new OwnerContext();
            db.Owners.Load();


            ownerDataGridView.DataSource = db.Owners.Local.ToBindingList();
        }

        //insert Owner
        private void InsertButton_Click(object sender, EventArgs e)
        {
            OwnerCardForm dc = new OwnerCardForm();
            DialogResult result = dc.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Owner owner = new Owner();
            owner.LastName = dc.lastNameTextBox.Text;
            owner.FirstName = dc.firstNameTextBox.Text;
            owner.FatherName = dc.fatherNameTextBox.Text;
            owner.Birthday = dc.birthdayDateTimePicker.Value;
            owner.Telephone = dc.telephoneTextBox.Text;
            owner.E_mail = dc.e_mailTextBox.Text;

            db.Owners.Add(owner);
            db.SaveChanges();
        }

        //метод update Owner
        public void UpdateOwnerForm()
        {
            if (ownerDataGridView.SelectedRows.Count > 0)
            {
                int index = ownerDataGridView.SelectedRows[0].Index;
                int OwnerId = 0;
                bool converted = Int32.TryParse(ownerDataGridView[0, index].Value.ToString(), out OwnerId);
                if (converted == false)
                    return;

                Owner owner = db.Owners.Find(OwnerId);

                OwnerCardForm dc = new OwnerCardForm();

                dc.ownerIDTextBox.Text = owner.OwnerId.ToString();
                dc.lastNameTextBox.Text = owner.LastName;
                dc.firstNameTextBox.Text = owner.FirstName;
                dc.fatherNameTextBox.Text = owner.FatherName;
                dc.birthdayDateTimePicker.Value = owner.Birthday;
                dc.telephoneTextBox.Text = owner.Telephone;
                dc.e_mailTextBox.Text = owner.E_mail;

                DialogResult result = dc.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                owner.LastName = dc.lastNameTextBox.Text;
                owner.FirstName = dc.firstNameTextBox.Text;
                owner.FatherName = dc.fatherNameTextBox.Text;
                owner.Birthday = dc.birthdayDateTimePicker.Value;
                owner.Telephone = dc.telephoneTextBox.Text;
                owner.E_mail = dc.e_mailTextBox.Text;

                db.SaveChanges();
                ownerDataGridView.Refresh();
            }
        }

        //update Owner
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateOwnerForm();
        }

        //open in treeview and update Owner
        private void ownerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateOwnerForm();
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
