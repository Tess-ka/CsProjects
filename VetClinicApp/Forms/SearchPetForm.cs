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
        OwnerContext db1;

        public SearchPetForm()
        {
            InitializeComponent();

            db = new PetContext();
            db.Pets.Load();

            db1 = new OwnerContext();
            db1.Owners.Load();
        }


    //Кнопка открытия формы питомца
    private void button_cardpet_open_Click(object sender, EventArgs e)
        {
            PetCardForm newForm = new PetCardForm(this);
            newForm.Show();
        }
        
        private void button_cardpet_open_new_Click(object sender, EventArgs e)
        {
            PetCardForm newForm = new PetCardForm(this);
            newForm.Show();
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

                            petDataGridView.DataSource = dt;
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

                            petDataGridView.DataSource = dt;
                            
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

    }
}

