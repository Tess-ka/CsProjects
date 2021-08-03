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


        public DoctorCardForm()
        {
            InitializeComponent();

            db = new ImagesContext();
            db.Images.Load();
        }

        //Выбор изображения
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Desktop";
                openFileDialog.Title = "Выберите изображение";
                openFileDialog.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                openFileDialog.FilterIndex = 1;

                try
                {
                    if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (openFileDialog.CheckFileExists)
                        {
                            string path = System.IO.Path.GetFullPath(openFileDialog.FileName);
                            FileName.Text = path;
                            DoctorPhoto.Image = new Bitmap(openFileDialog.FileName);
                            DoctorPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                    }

                    else
                    {
                        MessageBox.Show("Пожалуйста, загрузите изображение");
                    }
                }

                catch(Exception ex)
                {
                    //если файл уже существует
                    MessageBox.Show(ex.Message);
                }

            }
                
        }

        //загрузка изображения
        private void UploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            { 
                try
                {
                    string filename = System.IO.Path.GetFileName(openFileDialog.FileName);
                    if (filename == null)
                    {
                         MessageBox.Show("Пожалуйста, выберите подходящее изображение");
                    }
                    else
                    {

                        using (ImagesContext db = new ImagesContext())
                        {
                            var image = db.Database.SqlQuery<Image>("insert into Images (image)values('\\Image\\" + filename + "')");
                            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                            System.IO.File.Copy(openFileDialog.FileName, path + "\\Image\\" + filename);
                            int count = db.SaveChanges();
                            //ExecuteNonQuery();
                            db.Database.Connection.Close();

                            MessageBox.Show("Изображение успешно загружено");
                        }

                    }

                }
                 catch(Exception ex)
                {
                      MessageBox.Show(ex.Message, "Файл уже существует");
                }
            }
        }
    }
}
