﻿using System;
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
           // this.button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PetForm newForm = new PetForm(this);
            newForm.Show();
        }

        private void MainFormVet_Load(object sender, EventArgs e)
        {

        }
    }
}