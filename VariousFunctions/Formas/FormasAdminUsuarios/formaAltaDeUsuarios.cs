using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace VariousFunctions.Formas.FormasAdminUsuarios
{
    public partial class formaAltaDeUsuarios : Form
    {
        public formaAltaDeUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(fillCuenta.Text.Equals("") || fillNombre.Text.Equals("") || fillApellido.Text.Equals("") || fillPerfil.Text.Equals("") || fillPuesto.Text.Equals("") || fillContrasena2.Text.Equals("")))
            {
                if (!operations.userExists(fillCuenta.Text))
                {
                    if (fillContrasena1.Text.Equals(fillContrasena2.Text))
                    {

                        String finalContrasena = operations.createStoredPassword(fillContrasena2.Text);
                        operations.addUser(fillCuenta.Text, fillNombre.Text, fillApellido.Text, fillPerfil.Text, fillPuesto.Text, finalContrasena);
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                    }
                }
                else
                {
                    MessageBox.Show("La cuenta ingresada ya existe");
                }
            }
            else
            {
                MessageBox.Show("Asegúrese que los campos no estén vacíos");
            }
        }

        private void formaAltaDeUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            clearFields();
            staticFormContainer.formaAdminUsuarios.Show();
        }

        public void clearFields()
        {
            fillCuenta.Clear();
            fillNombre.Clear();
            fillApellido.Clear();
            fillPerfil.Clear();
            fillPuesto.Clear();
            fillContrasena1.Clear();
            fillContrasena2.Clear();
        }
    }
}
