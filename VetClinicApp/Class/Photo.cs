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
    class Photo
    {
        public static int PhotoAttachment(string PathToFile, PictureBox DoctorPhoto)
        {
            ImagesContext db;

            db = new ImagesContext();
            db.Images.Load();

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
                            PathToFile = path;

                            DoctorPhoto.Image = new Bitmap(openFileDialog.FileName);
                            DoctorPhoto.SizeMode = PictureBoxSizeMode.Zoom;

                            string filename = System.IO.Path.GetFileName(openFileDialog.FileName);

                            string pathf = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                            int imageInsert = db.Database.ExecuteSqlCommand("Insert into Images (images, path) Values ('\\Image\\" + filename + "', '" + pathf + "\\Image\\" + filename + "')");

                            System.IO.File.Copy(openFileDialog.FileName, pathf + "\\Image\\" + filename);
                            int count = db.SaveChanges();

                            string NameImage = "\\Image\\" + filename;

                            var idim = from im in db.Images
                                       where im.Images == NameImage
                                       select im.Id;

                            var id = idim.FirstOrDefault();

                            return id;
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
                return 0;
            }
        }
    }
}
