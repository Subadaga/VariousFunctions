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
    public partial class formaBajaDeUsuarios : Form
    {
        public formaBajaDeUsuarios()
        {
            InitializeComponent();
        }

        private void bajaBoton_Click(object sender, EventArgs e)
        {
            if (operations.userExists(fillBaja.Text))
            {
                operations.darDeBaja(fillBaja.Text);
                MessageBox.Show("La cuenta se ha desactivado");
                fillBaja.Clear();
            }
            else
            {
                MessageBox.Show("El usuario ingresado no existe");
            }
        }
    }
}
