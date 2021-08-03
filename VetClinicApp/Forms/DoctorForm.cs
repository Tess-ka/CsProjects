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

        //insert
        private void InsertButton_Click(object sender, EventArgs e)
        {
            DoctorCardForm dc = new DoctorCardForm();
            DialogResult result = dc.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Doctor doctor = new Doctor();
            doctor.Lastname = dc.lastnameTextBox.Text;
            doctor.Firstname = dc.firstnameTextBox.Text;
            doctor.Fathername = dc.fathernameTextBox.Text;
            doctor.Birthday = dc.birthdayDateTimePicker.Value;
            doctor.Qualification = dc.qualificationTextBox.Text;

            db.Doctors.Add(doctor);
            db.SaveChanges();

            MessageBox.Show("Новый ветеринар добавлен");
        }

        //update
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (doctorDataGridView.SelectedRows.Count > 0)
            {
                int index = doctorDataGridView.SelectedRows[0].Index;
                int DoctorId = 0;
                bool converted = Int32.TryParse(doctorDataGridView[0, index].Value.ToString(), out DoctorId);
                if (converted == false)
                    return;

                Doctor doctor = db.Doctors.Find(DoctorId);

                DoctorCardForm dc = new DoctorCardForm();

                dc.lastnameTextBox.Text = doctor.Lastname;
                dc.firstnameTextBox.Text = doctor.Firstname;
                dc.fathernameTextBox.Text = doctor.Fathername;
                dc.birthdayDateTimePicker.Value = doctor.Birthday.Value;
                dc.qualificationTextBox.Text = doctor.Qualification;

                DialogResult result = dc.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                doctor.Lastname = dc.lastnameTextBox.Text;
                doctor.Firstname = dc.firstnameTextBox.Text;
                doctor.Fathername = dc.fathernameTextBox.Text;
                doctor.Birthday = dc.birthdayDateTimePicker.Value;
                doctor.Qualification = dc.qualificationTextBox.Text;

                db.SaveChanges();
                doctorDataGridView.Refresh();

                MessageBox.Show("Ветеринар изменён");
            }
        }

        //Delete
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (doctorDataGridView.SelectedRows.Count > 0)
            {
                int index = doctorDataGridView.SelectedRows[0].Index;
                int DoctorId = 0;
                bool converted = Int32.TryParse(doctorDataGridView[0, index].Value.ToString(), out DoctorId);
                if (converted == false)
                    return;

                Doctor doctor = db.Doctors.Find(DoctorId);
                db.Doctors.Remove(doctor);
                db.SaveChanges();

                MessageBox.Show("Ветеринар удалён");
            }

        }

    }


}

