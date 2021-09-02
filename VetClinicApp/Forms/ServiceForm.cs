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
    public partial class ServiceForm : Form
    {
        ServiceContext sc;

        public ServiceForm()
        {
            InitializeComponent();

            sc = new ServiceContext();
            sc.services.Load();

            serviceDataGridView.DataSource = sc.services.Local.ToBindingList();
        }

        //добавить услугу
        private void InsertButton2_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            ServiceCardForm scf = new ServiceCardForm(null);
            DialogResult result = scf.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            sc.services.Add(scf.GetServ);
            sc.SaveChanges();
        }

        //открыть/редактировать услугу
        private void serviceDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (serviceDataGridView.SelectedRows.Count > 0)
            {
                int index = serviceDataGridView.SelectedRows[0].Index;
                int ServiceId = 0;
                bool converted = Int32.TryParse(serviceDataGridView[0, index].Value.ToString(), out ServiceId);
                if (converted == false)
                    return;

                Service service = sc.services.Find(ServiceId);
                ServiceCardForm scf = new ServiceCardForm(service);

                sc.SaveChanges();
                serviceDataGridView.Refresh();
            }
        }

        //Удалить услугу
        private void DeleteButton3_Click(object sender, EventArgs e)
        {
            if (serviceDataGridView.SelectedRows.Count > 0)
            {
                int index = serviceDataGridView.SelectedRows[0].Index;
                int ServiceId = 0;
                bool converted = Int32.TryParse(serviceDataGridView[0, index].Value.ToString(), out ServiceId);
                if (converted == false)
                    return;

                Service service = sc.services.Find(ServiceId);
                sc.services.Remove(service);
                sc.SaveChanges();

                MessageBox.Show("Услуга удалена");
            }
        }
    }
}
