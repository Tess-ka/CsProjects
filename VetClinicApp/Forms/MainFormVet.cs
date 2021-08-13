using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinicApp
{
    public partial class MainFormVet : Form
    {

        public MainFormVet()
        {
            InitializeComponent();
        }

        private void ProgramMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What? O_o");
        }

        //private void OwnerMenuItem_Click(object sender, EventArgs e)
        //{
        //    OwnerForm newMDIChild = new OwnerForm();
        //    newMDIChild.MdiParent = this;
        //    newMDIChild.Show();
        //}

        //private void DoctorMenuItem_Click(object sender, EventArgs e)
        //{
        //    DoctorForm newMDIChild = new DoctorForm();
        //    newMDIChild.MdiParent = this;
        //    newMDIChild.Show();
        //}

        //Поиск питомца
        private void PetSearchMenuItem_Click(object sender, EventArgs e)
        {
            SearchPetForm newMDIChild = new SearchPetForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "Node1")

            {
                //Открытие формы списка питомцев
                PetForm owner = new PetForm();
                owner.MdiParent = this;
                owner.Show();
            }

            else if(e.Node.Name == "Node2")

            {
                //Открытие формы списка владельцев
                OwnerForm owner = new OwnerForm();
                owner.MdiParent = this;
                owner.Show();
            }

            else if (e.Node.Name == "Node3")
            {
                //Открытие формы списка ветеринаров
                DoctorForm doctor = new DoctorForm();
                doctor.MdiParent = this;
                doctor.Show();
            }

            else if (e.Node.Name == "Node4")
            {
                //Открытие формы списка услуг
                ServiceForm service = new ServiceForm();
                service.MdiParent = this;
                service.Show();
            }

            else if (e.Node.Name == "Node7")
            {
                //Открытие формы списка прививок
                VaccinationsForm Vacc = new VaccinationsForm();
                Vacc.MdiParent = this;
                Vacc.Show();
            }

            else if (e.Node.Name == "Node6")
            {
                //Открытие формы списка случаев лечения
                TreatmentCaseForm TreatmentCase = new TreatmentCaseForm();
                TreatmentCase.MdiParent = this;
                TreatmentCase.Show();
            }
        }

        private void MainFormVet_Load(object sender, EventArgs e)
        {

        }

        //Закрыть приложение
        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
