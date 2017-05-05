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
    public partial class formaReseteoContrasena : Form
    {
        public formaReseteoContrasena()
        {
            InitializeComponent();
        }

        private void fillUsuarioMod_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonRegreso_Click(object sender, EventArgs e)
        {
            this.Hide();

            fillUsuarioMod.Clear();
            staticFormContainer.formaAdminUsuarios.Show();

        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            String usuario = fillUsuarioMod.Text;
            String contrasena1 = contrasena1Confirmacion.Text;
            String contrasena2 = contrasena2Confirmacion.Text;

            if(!(usuario.Equals("") || contrasena1.Equals("") || contrasena2.Equals("")))
            {
                if (operations.userExists(usuario))
                {
                    if (contrasena1.Equals(contrasena2))
                    {
                        operations.agregarContrasenaAHistoria(usuario);
                        String finalContrasena = operations.createStoredPassword(contrasena1);
                        if (!operations.contrasenaYaUsada(usuario, finalContrasena)) {
                            operations.modificarAtributo(usuario, 4, finalContrasena);
                        }
                        else
                        {
                            MessageBox.Show("Esa contraseña ya fue utilizada");
                        }
                        


                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario indicado no existe");
                }
            }
            else
            {
                MessageBox.Show("Asegúrese que los campos no están vacíos");
            }
        }

        public void clearFields()
        {
            fillUsuarioMod.Clear();
            contrasena1Confirmacion.Clear();
            contrasena2Confirmacion.Clear();
        }
    }
}
