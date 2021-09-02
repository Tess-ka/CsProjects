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
using System.Collections.ObjectModel;

namespace VetClinicApp
{
    public partial class OwnerCardForm : Form
    {
        PetContext db;
        ImagesContext db1;
        private Owner Own;


        public OwnerCardForm(Owner owner)
        {
            InitializeComponent();

            db = new PetContext();
            db.Pets.Load();

            db1 = new ImagesContext();
            db1.Images.Load();

            if (owner == null)
            {
                Own = new Owner();
            }
            else
            {
                Own = owner;
                this.ownerIDTextBox.Text = owner.OwnerId.ToString();
                this.lastNameTextBox.Text = owner.LastName;
                this.firstNameTextBox.Text = owner.FirstName;
                this.fatherNameTextBox.Text = owner.FatherName;
                this.birthdayDateTimePicker.Value = owner.Birthday;
                this.telephoneTextBox.Text = owner.Telephone;
                this.e_mailTextBox.Text = owner.E_mail;
                this.addressTextBox.Text = owner.Address;

                var d = from im in db1.Images
                        where im.Id == owner.Photo
                        select im.Path;
                var imm = d.FirstOrDefault();

                if (imm != null)
                {
                    this.pictureBox1.Image = new Bitmap(imm);
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }

                //DataSet ds = new DataSet();
                //ds.Tables.Add ();
                petDataGridView.DataSource = owner.Pets.ToList();
                //petDataGridView.DataSource = ds;
                //petDataGridView.DataSource = db.Pets.Local.ToBindingList();

                //var pp = from p in db.Pets
                //         where p.OwnerID == owner.OwnerId
                //         select p;
                //DataTable dt = new DataTable();


                //petDataGridView.DataSource = dt;

                DialogResult result = ShowDialog();
                if (result == DialogResult.Cancel)
                    return;
            }
        }

        public Owner GetOwner => this.Own;

        protected override void OnClosing(CancelEventArgs e)
        {
            if (!e.Cancel)
            {
                Own.LastName = this.lastNameTextBox.Text;
                Own.FirstName = this.firstNameTextBox.Text;
                Own.FatherName = this.fatherNameTextBox.Text;
                Own.Birthday = this.birthdayDateTimePicker.Value;
                Own.Telephone = this.telephoneTextBox.Text;
                Own.E_mail = this.e_mailTextBox.Text;
                Own.Address = this.addressTextBox.Text;
            }
            base.OnClosing(e);
        }

        //Добавление фото
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (this.ownerIDTextBox.Text == "")
            {
                MessageBox.Show("Сохраните данные");
            }
            else
            {
                int id = Photo.PhotoAttachment(PathToFile.Text, pictureBox1);

                using (var context = new OwnerContext())
                {
                    int owid = int.Parse(this.ownerIDTextBox.Text);

                    Owner owner = context.Owners.Single(own => own.OwnerId == owid);
                    owner.Photo = id;
                    context.SaveChanges();
                }
            }
        }

        //insert pet
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            PetCardForm dc = new PetCardForm(null);
            dc.Owner = this;
            DialogResult result = dc.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            db.Pets.Add(dc.GetPet);
            db.SaveChanges();
            this.petDataGridView.Refresh();//не работает
            //this.petDataGridView.Update();
        }

        //open pet from
        private void petDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (petDataGridView.SelectedRows.Count > 0)
            {
                int index = petDataGridView.SelectedRows[0].Index;
                int PetId = 0;
                bool converted = Int32.TryParse(petDataGridView[0, index].Value.ToString(), out PetId);
                if (converted == false)
                    return;

                Pet pet = db.Pets.Find(PetId);
                PetCardForm dc = new PetCardForm(pet);

                db.SaveChanges();
                petDataGridView.Refresh();
            }
        }

        //delete pet
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (petDataGridView.SelectedRows.Count > 0)
            {
                int index = petDataGridView.SelectedRows[0].Index;
                int PetId = 0;
                bool converted = Int32.TryParse(petDataGridView[0, index].Value.ToString(), out PetId);
                if (converted == false)
                    return;

                Pet pet = db.Pets.Find(PetId);
                db.Pets.Remove(pet);
                db.SaveChanges();

                MessageBox.Show("Питомец удалён");
            }
        }

        private void OwnerCardForm_Load(object sender, EventArgs e)
        {
            //this.petsTableAdapter.Fill(this.dbconnectionDataSet.Pets);

        }
    }
}
