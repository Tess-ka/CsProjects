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
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;database=DBVETCLINICA;Integrated Security=True";

        public SearchPetForm()
        {
            InitializeComponent();

        }

        //private void petBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.petBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dBVetClinicaDataSet);

        //}

        //заоплняет поля перыми данными из списка по умолчанию

        private void SearchPetForm_Load(object sender, EventArgs e)
        {
            //    // TODO: This line of code loads data into the 'dBVetClinicaDataSet.TreatmentСase' table. You can move, or remove it, as needed.
            //    this.treatmentСaseTableAdapter.Fill(this.dBVetClinicaDataSet.TreatmentСase);
            //    // TODO: This line of code loads data into the 'dBVetClinicaDataSet.Owner' table. You can move, or remove it, as needed.
            //    this.ownerTableAdapter.Fill(this.dBVetClinicaDataSet.Owner);
            //    // TODO: This line of code loads data into the 'dBVetClinicaDataSet.Pet' table. You can move, or remove it, as needed.
            //    this.petTableAdapter.Fill(this.dBVetClinicaDataSet.Pet);
            //Connect to sql database

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
        //        using (DBVetClinicaDataSet db = new DBVetClinicaDataSet())
        //        {

        //        }
        //    } 
        // }


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

                            //petIdTextBox.Text = 




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

