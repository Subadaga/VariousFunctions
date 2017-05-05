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
    public partial class modificacionUsuarios : Form
    {
        public modificacionUsuarios()
        {
            InitializeComponent();
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            String usuario = fillUsuarioMod.Text.Replace(" ", "");
            String valorNuevo = nuevoValor.Text.Replace(" ", "");

            if (!(usuario.Equals("") || valorNuevo.Equals(""))) {
                if (operations.userExists(fillUsuarioMod.Text))
                {
                    if (!operations.userIsDown(usuario))
                    {
                        switch (comboBoxMod.SelectedIndex)
                        {
                            case 0:
                                operations.modificarAtributo(usuario, 0, valorNuevo);
                                break;
                            case 1:
                                operations.modificarAtributo(usuario, 1, valorNuevo);
                                break;
                            case 2:
                                operations.modificarAtributo(usuario, 2, valorNuevo);
                                break;
                            case 3:
                                operations.modificarAtributo(usuario, 3, valorNuevo);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario está dado de baja");
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

        private void modificacionUsuarios_Load(object sender, EventArgs e)
        {
            comboBoxMod.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {

            grupoSeleccionMod.Visible = true;
        }

        private void comboBoxMod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonRegreso_Click(object sender, EventArgs e)
        {
            this.Hide();
            comboBoxMod.SelectedIndex = 0;
            fillUsuarioMod.Clear();
            nuevoValor.Clear();
            staticFormContainer.formaAdminUsuarios.Show();

        }
    }
}
