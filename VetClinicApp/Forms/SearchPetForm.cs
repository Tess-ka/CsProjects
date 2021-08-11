using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Entity;

namespace VetClinicApp
{
    public partial class SearchPetForm : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nastya.Nazarycheva\source\repos\CsProjects\VetClinicApp\DBVetClinica.mdf;Integrated Security=True";
        PetContext db;
        OwnerContext ow;

        public SearchPetForm()
        {
            InitializeComponent();

            db = new PetContext();
            db.Pets.Load();

            ow = new OwnerContext();
            ow.Owners.Load();
        }


    

        //private void button_search_pet_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        using (var context = new PetContext())
        //        {
        //            var pets = context.Pets.SqlQuery("select *from Pet where PetId=@PetId or Name like @Name").ToList();
        //            pets.
 
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //Поиск по питомцу
        private void button_search_pet_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    using (DataTable dt = new DataTable("Pet"))
                    {

                        using (SqlCommand cmd = new SqlCommand("select *from Pet where PetId=@PetId or Name like @Name", connection))
                        {
                            cmd.Parameters.AddWithValue("PetId", txtSearchPet.Text);
                            cmd.Parameters.AddWithValue("Name", string.Format("%{0}%", txtSearchPet.Text));
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);

                            //petDataGridView.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchPet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//enter
                button_search_pet.PerformClick();
        }

        //Поиск по владельцу
        private void button_search_owner_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    using (DataTable dt = new DataTable("Owner"))
                    {
                        using (SqlCommand cmd = new SqlCommand("select *from Owner where OwnerId=@OwnerId or LastName like @LastName", connection))
                        {
                            cmd.Parameters.AddWithValue("OwnerId", txtSearch.Text);
                            cmd.Parameters.AddWithValue("LastName", string.Format("%{0}%", txtSearch.Text));
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);

                            //petDataGridView.DataSource = dt;
                            
                        }
                    }
                }
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//enter
                button_search_owner.PerformClick();
        }



        //открыть карту владельца
        private void button3_Click(object sender, EventArgs e)
        {
            if (ownerIdTextBox.Text != null)
            {
                int OwnerId = int.Parse(ownerIdTextBox.Text); ;
                
                Owner owner = ow.Owners.Find(OwnerId);

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
            }
        }

        //новый владелец
        private void button4_Click(object sender, EventArgs e)
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

            ow.Owners.Add(owner);
            ow.SaveChanges();
        }

        //Кнопка открытия формы питомца
        private void button_cardpet_open_Click(object sender, EventArgs e)
        {
            if (petIdTextBox.Text != null)
            {
                int PetId = int.Parse(petIdTextBox.Text);

                Pet pet = db.Pets.Find(PetId);

                PetCardForm dc = new PetCardForm();

                dc.petIdTextBox1.Text = pet.PetId.ToString();
                dc.nameTextBox1.Text = pet.Name;
                dc.sexComboBox.Text = pet.Sex;
                dc.birthdayTextBox.Text = pet.Birthday;
                dc.speciesTextBox.Text = pet.Species;
                dc.breedTypeTextBox.Text = pet.BreedType;
                dc.colourTextBox.Text = pet.Colour;

                DialogResult result = dc.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                pet.Name = dc.nameTextBox1.Text;
                pet.Sex = dc.sexComboBox.Text;
                pet.Birthday = dc.birthdayTextBox.Text;
                pet.Species = dc.speciesTextBox.Text;
                pet.BreedType = dc.breedTypeTextBox.Text;
                pet.Colour = dc.colourTextBox.Text;

                db.SaveChanges();
            }
        }

        //новый питомец
        private void button_cardpet_open_new_Click(object sender, EventArgs e)
        {
            if (ownerIdTextBox.Text != null)
            {
                PetCardForm dc = new PetCardForm();
                DialogResult result = dc.ShowDialog();

                if (result == DialogResult.Cancel)
                    return;

                Pet pet = new Pet();
                pet.Name = dc.nameTextBox1.Text;
                pet.Sex = dc.sexComboBox.Text;
                pet.Birthday = dc.birthdayTextBox.Text;
                pet.Species = dc.speciesTextBox.Text;
                pet.BreedType = dc.breedTypeTextBox.Text;
                pet.Colour = dc.colourTextBox.Text;
                pet.OwnerID = int.Parse(ownerIdTextBox.Text);

                db.Pets.Add(pet);
                db.SaveChanges();
            }
        }
    }
}

