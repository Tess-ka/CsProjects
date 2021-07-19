using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinicApp
{
    public partial class MainFormVet : Form
    {

        public MainFormVet()
        {
            InitializeComponent();
        }

  
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    PetForm newForm = new PetForm(this);
        //    newForm.Show();
        //}


        private void PetMenuItem_Click(object sender, EventArgs e)
        {
            PetForm newMDIChild = new PetForm();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void ProgramMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("О программе");
        }

        private void OwnerMenuItem_Click(object sender, EventArgs e)
        {
            OwnerForm newMDIChild = new OwnerForm();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }
    }
}
