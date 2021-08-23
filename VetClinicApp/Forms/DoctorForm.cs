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

        //insert Doctor
        private void InsertButton_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            DoctorCardForm dc = new DoctorCardForm(null);
            DialogResult result = dc.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            db.Doctors.Add(dc.GetDoctor);
            db.SaveChanges();
        }

        //open DoctorForm & update
        private void doctorDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (doctorDataGridView.SelectedRows.Count > 0)
            {
                int index = doctorDataGridView.SelectedRows[0].Index;
                int DoctorId = 0;
                bool converted = Int32.TryParse(doctorDataGridView[0, index].Value.ToString(), out DoctorId);
                if (converted == false)
                    return;

                Doctor doctor = db.Doctors.Find(DoctorId);
                DoctorCardForm dc = new DoctorCardForm(doctor);

                db.SaveChanges();
                doctorDataGridView.Refresh();
            }
        }

        //Delete Doctor
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




