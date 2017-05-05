using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariousFunctions.Formas.FormasAdminUsuarios
{
    public partial class formaDesbloqueoUsuario : Form
    {
        public formaDesbloqueoUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fillBaja.Clear();
            staticFormContainer.formaAdminUsuarios.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fillBaja_TextChanged(object sender, EventArgs e)
        {

        }

        private void bajaBoton_Click(object sender, EventArgs e)
        {
            if (operations.userExists(fillBaja.Text))
            {
                operations.modificarAtributo(fillBaja.Text, 6, "true");
                MessageBox.Show("La cuenta se ha desbloqueado");
                operations.modificarAtributo(fillBaja.Text, 11, "0");
                fillBaja.Clear();
            }
            else
            {
                MessageBox.Show("El usuario ingresado no existe");
            }
        }
    }
}
