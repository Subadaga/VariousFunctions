﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariousFunctions
{
    public partial class formaMenuPrincipal : Form
    {

        private Random random = new Random();

        public formaMenuPrincipal()
        {
            InitializeComponent();
        }

        private void accionBoton_Click(object sender, EventArgs e)
        {
            cachafasTexto.ForeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formas.formaAdministracionUsuarios formaAdminUsuarios = new Formas.formaAdministracionUsuarios();
            this.Hide();
            formaAdminUsuarios.Show();

        }
    }
}