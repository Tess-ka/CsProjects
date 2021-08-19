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

        public DoctorCardForm(Doctor doctor)
        {
            InitializeComponent();

            db = new ImagesContext();
            db.Images.Load();

            this.doctorId.Text = doctor.DoctorId.ToString();
            this.lastnameTextBox.Text = doctor.Lastname;
            this.firstnameTextBox.Text = doctor.Firstname;
            this.fathernameTextBox.Text = doctor.Fathername;
            this.birthdayDateTimePicker.Value = doctor.Birthday.Value;
            this.phoneTextBox.Text = doctor.Phone;
            this.qualificationTextBox.Text = doctor.Qualification;

            var d = from im in db.Images
                    where im.Id == doctor.Photo
                    select im.Path;
            var imm = d.FirstOrDefault();

            if (imm != null)
            {
            this.DoctorPhoto.Image = new Bitmap(imm);
            this.DoctorPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            DialogResult result = this.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            doctor.Lastname = this.lastnameTextBox.Text;
            doctor.Firstname = this.firstnameTextBox.Text;
            doctor.Fathername = this.fathernameTextBox.Text;
            doctor.Birthday = this.birthdayDateTimePicker.Value;
            doctor.Phone = this.phoneTextBox.Text;
            doctor.Qualification = this.qualificationTextBox.Text;
        }


        //Выбор изображения
        private void BrowseButton_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Desktop";
                openFileDialog.Title = "Выберите изображение";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                openFileDialog.FilterIndex = 1;

                try
                {
                    if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (openFileDialog.CheckFileExists)
                        {
                            string path = System.IO.Path.GetFullPath(openFileDialog.FileName);
                            PathToFile.Text = path;
                            DoctorPhoto.Image = new Bitmap(openFileDialog.FileName);
                            DoctorPhoto.SizeMode = PictureBoxSizeMode.StretchImage;

                            string filename = System.IO.Path.GetFileName(openFileDialog.FileName);

                            string pathf = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                            int imageInsert = db.Database.ExecuteSqlCommand("Insert into Images (images, path) Values ('\\Image\\" + filename + "', '"+pathf + "\\Image\\" + filename+"')");

                            System.IO.File.Copy(openFileDialog.FileName, pathf + "\\Image\\" + filename);
                            int count = db.SaveChanges();

                            string NameImage = "\\Image\\" + filename;

                            var idim = from im in db.Images
                                        where im.Images == NameImage
                                        select im.Id;

                            var id = idim.FirstOrDefault();

                            using (var context = new DoctorContext())
                            {
                                int docid = int.Parse(this.doctorId.Text);

                                Doctor doctor = context.Doctors.Single(doc => doc.DoctorId == docid);
                                doctor.Photo = id;
                                context.SaveChanges();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, загрузите изображение");
                    }
                }

                catch (Exception ex)
                {
                    //если файл уже существует
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DoctorCardForm_Load(object sender, EventArgs e)
        {

        }

        public void OpenDoctorForm(Doctor doctor)
        {
            //if (doctorDataGridView.SelectedRows.Count > 0)
            //{
            //    int index = doctorDataGridView.SelectedRows[0].Index;
            //    int DoctorId = 0;
            //    bool converted = Int32.TryParse(doctorDataGridView[0, index].Value.ToString(), out DoctorId);
            //    if (converted == false)
            //        return;

            //    Doctor doctor = db.Doctors.Find(DoctorId);

            //DoctorCardForm dc = new DoctorCardForm();

            this.doctorId.Text = doctor.DoctorId.ToString();
            this.lastnameTextBox.Text = doctor.Lastname;
            this.firstnameTextBox.Text = doctor.Firstname;
            this.fathernameTextBox.Text = doctor.Fathername;
            this.birthdayDateTimePicker.Value = doctor.Birthday.Value;
            this.phoneTextBox.Text = doctor.Phone;
            this.qualificationTextBox.Text = doctor.Qualification;

                DialogResult result = this.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                doctor.Lastname = this.lastnameTextBox.Text;
                doctor.Firstname = this.firstnameTextBox.Text;
                doctor.Fathername = this.fathernameTextBox.Text;
                doctor.Birthday = this.birthdayDateTimePicker.Value;
                doctor.Phone = this.phoneTextBox.Text;
                doctor.Qualification = this.qualificationTextBox.Text;

                db.SaveChanges();
                //doctorDataGridView.Refresh();
            }
    }
}
