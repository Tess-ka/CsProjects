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
   
    public partial class DoctorCardForm : Form
    {
        ImagesContext db;

        private Doctor Doctor;

        public DoctorCardForm(Doctor doctor)
        {
            InitializeComponent();

            db = new ImagesContext();
            db.Images.Load();

            if (doctor == null)
            {
                Doctor = new Doctor();
            }
            else
            {
                Doctor = doctor;
                this.doctorId.Text = doctor.DoctorId.ToString();
                this.lastnameTextBox.Text = doctor.Lastname;
                this.firstnameTextBox.Text = doctor.Firstname;
                this.fathernameTextBox.Text = doctor.Fathername;
                this.birthdayDateTimePicker.Value = doctor.Birthday;
                this.phoneTextBox.Text = doctor.Phone;
                this.qualificationTextBox.Text = doctor.Qualification;

                var d = from im in db.Images
                        where im.Id == doctor.Photo
                        select im.Path;
                var imm = d.FirstOrDefault();

                if (imm != null)
                {
                    this.DoctorPhoto.Image = new Bitmap(imm);
                    this.DoctorPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                }

                DialogResult result = ShowDialog();
                if (result == DialogResult.Cancel)
                    return;
            }
        }

        public Doctor GetDoctor => this.Doctor;

        protected override void OnClosing(CancelEventArgs e)
        {
            if (!e.Cancel)
            {
                Doctor.Lastname = this.lastnameTextBox.Text;
                Doctor.Firstname = this.firstnameTextBox.Text;
                Doctor.Fathername = this.fathernameTextBox.Text;
                Doctor.Birthday = this.birthdayDateTimePicker.Value;
                Doctor.Phone = this.phoneTextBox.Text;
                Doctor.Qualification = this.qualificationTextBox.Text;
            }
            base.OnClosing(e);
        }

        //Добавление фото
        private void BrowseButton_Click_1(object sender, EventArgs e)
        {
            if (this.doctorId.Text == "")
            {
                MessageBox.Show("Сохраните данные");
            }
            else
            {
                int id = Photo.PhotoAttachment(PathToFile.Text, DoctorPhoto);

                using (var context = new DoctorContext())
                {
                    int docid = int.Parse(this.doctorId.Text);

                    Doctor doctor = context.Doctors.Single(doc => doc.DoctorId == docid);
                    doctor.Photo = id;
                    context.SaveChanges();
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения?", "Закрытие формы", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var context = new DoctorContext())
                {

                    //Doctor.Lastname = this.lastnameTextBox.Text;
                    //Doctor.Firstname = this.firstnameTextBox.Text;
                    //Doctor.Fathername = this.fathernameTextBox.Text;
                    //Doctor.Birthday = this.birthdayDateTimePicker.Value;
                    //Doctor.Phone = this.phoneTextBox.Text;
                    //Doctor.Qualification = this.qualificationTextBox.Text;

                    //context.SaveChanges();
                    //this.Show();
                }    
                    
                //this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}

