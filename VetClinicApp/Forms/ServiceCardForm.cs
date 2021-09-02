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
    public partial class ServiceCardForm : Form
    {
        private Service Serv;

        public ServiceCardForm(Service service)
        {
            InitializeComponent();

            if (service == null)
            {
                Serv = new Service();
            }
            else
            {
                Serv = service;
                this.nameTextBox.Text = service.Name;
                this.priceTextBox.Text = service.Price;
                this.сategoryTextBox.Text = service.Сategory;
                this.indexTextBox.Text = service.Index.ToString();

                DialogResult result = ShowDialog();
                if (result == DialogResult.Cancel)
                    return;
            }
        }

        public Service GetServ => this.Serv;

        protected override void OnClosing(CancelEventArgs e)
        {
            if (!e.Cancel)
            {
                Serv.Name = this.nameTextBox.Text;
                Serv.Price = this.priceTextBox.Text;
                Serv.Сategory = this.сategoryTextBox.Text;
                Serv.Index = int.Parse(this.indexTextBox.Text);
            }
            base.OnClosing(e);
        }
    }
}
