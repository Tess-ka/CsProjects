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
    public partial class DoctorForm : Form
    {
        DoctorContext db;

        public DoctorForm()
        {
            InitializeComponent();

            db = new DoctorContext();
            db.Doctors.Load();

            doctorDataGridView.DataSource = db.Doctors.Local.ToBindingList();
        }

        //insert Doctor
        private void InsertButton_Click(object sender, EventArgs e)
        {
            //DoctorCardForm dc = new DoctorCardForm();
            //DialogResult result = dc.ShowDialog(this);

            //if (result == DialogResult.Cancel)
            //    return;

            //Doctor doctor = new Doctor();
            //doctor.Lastname = dc.lastnameTextBox.Text;
            //doctor.Firstname = dc.firstnameTextBox.Text;
            //doctor.Fathername = dc.fathernameTextBox.Text;
            //doctor.Birthday = dc.birthdayDateTimePicker.Value;
            //doctor.Phone = dc.phoneTextBox.Text;
            //doctor.Qualification = dc.qualificationTextBox.Text;

            //db.Doctors.Add(doctor);
            //db.SaveChanges();
        }

        //метод update
        public void UpdateDoctorForm()
        {
            if (doctorDataGridView.SelectedRows.Count > 0)
            {
                int index = doctorDataGridView.SelectedRows[0].Index;
                int DoctorId = 0;
                bool converted = Int32.TryParse(doctorDataGridView[0, index].Value.ToString(), out DoctorId);
                if (converted == false)
                    return;

                Doctor doctor = db.Doctors.Find(DoctorId);
                DoctorCardForm dc = new DoctorCardForm(doctor);
                dc.Show();

                //    dc.doctorId.Text = doctor.DoctorId.ToString();
                //    dc.lastnameTextBox.Text = doctor.Lastname;
                //    dc.firstnameTextBox.Text = doctor.Firstname;
                //    dc.fathernameTextBox.Text = doctor.Fathername;
                //    dc.birthdayDateTimePicker.Value = doctor.Birthday.Value;
                //    dc.phoneTextBox.Text = doctor.Phone;
                //    dc.qualificationTextBox.Text = doctor.Qualification;

                //DialogResult result = dc.ShowDialog();

                //if (result == DialogResult.Cancel)
                //    return;

                //    doctor.Lastname = dc.lastnameTextBox.Text;
                //    doctor.Firstname = dc.firstnameTextBox.Text;
                //    doctor.Fathername = dc.fathernameTextBox.Text;
                //    doctor.Birthday = dc.birthdayDateTimePicker.Value;
                //    doctor.Phone = dc.phoneTextBox.Text;
                //    doctor.Qualification = dc.qualificationTextBox.Text;

                db.SaveChanges();
                doctorDataGridView.Refresh();
            }
        }

        //Update Doctor
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateDoctorForm();
        }

        //open DoctorForm & update
        private void doctorDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDoctorForm();
        }

        ////Delete Doctor
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //    if (doctorDataGridView.SelectedRows.Count > 0)
            //    {
            //        int index = doctorDataGridView.SelectedRows[0].Index;
            //        int DoctorId = 0;
            //        bool converted = Int32.TryParse(doctorDataGridView[0, index].Value.ToString(), out DoctorId);
            //        if (converted == false)
            //            return;

            //        Doctor doctor = db.Doctors.Find(DoctorId);
            //        db.Doctors.Remove(doctor);
            //        db.SaveChanges();

            //        MessageBox.Show("Ветеринар удалён");
        }

    }

}




