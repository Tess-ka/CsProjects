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

        public PetCardForm(SearchPetForm f)
        {
            InitializeComponent();
        }

        public PetCardForm()
        {
            InitializeComponent();

            oc = new OwnerContext();
            oc.Owners.Load();

            //if (ownerIDLabel1.Text != null)
            //{
            //    Owner owner = oc.Owners.Find(int.Parse(ownerIDLabel1.Text));

            //    OwnerCardForm dc = new OwnerCardForm();

            //    FIOOwnerlabel.Text = dc.lastNameTextBox.Text + dc.firstNameTextBox.Text + dc.fatherNameTextBox.Text;
            //}
                
        }

        //Открытие формы владельца
        private void button3_Click(object sender, EventArgs e)
        {
            if (ownerIDLabel1.Text != null)
            {
                Owner owner = oc.Owners.Find(int.Parse(ownerIDLabel1.Text));

                //OwnerCardForm dc = new OwnerCardForm();

                //dc.ownerIDTextBox.Text = owner.OwnerId.ToString();
                //dc.lastNameTextBox.Text = owner.LastName;
                //dc.firstNameTextBox.Text = owner.FirstName;
                //dc.fatherNameTextBox.Text = owner.FatherName;
                //dc.birthdayDateTimePicker.Value = owner.Birthday;
                //dc.telephoneTextBox.Text = owner.Telephone;
                //dc.e_mailTextBox.Text = owner.E_mail;

                //DialogResult result = dc.ShowDialog(this);

                //if (result == DialogResult.Cancel)
                //    return;

                //owner.LastName = dc.lastNameTextBox.Text;
                //owner.FirstName = dc.firstNameTextBox.Text;
                //owner.FatherName = dc.fatherNameTextBox.Text;
                //owner.Birthday = dc.birthdayDateTimePicker.Value;
                //owner.Telephone = dc.telephoneTextBox.Text;
                //owner.E_mail = dc.e_mailTextBox.Text;

                oc.SaveChanges();
            }
        }
    }
}
