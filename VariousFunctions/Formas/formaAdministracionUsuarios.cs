using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariousFunctions.Formas
{
    public partial class formaAdministracionUsuarios : Form
    {
        public formaAdministracionUsuarios()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    this.Hide();
                    staticFormContainer.formaAltaUsuarios.Show();
                    break;
                case 1:
                    this.Hide();
                    staticFormContainer.formaBajaUsuarios.Show();
                    break;
                case 2:
                    this.Hide();
                    staticFormContainer.modificacionUsuarios.Show();
                    break;
                case 3:
                    this.Hide();
                    staticFormContainer.formaReseteoContrasena.Show();
                    break;
                case 4:
                    this.Hide();
                    staticFormContainer.desbloqueoUsuarios.Show();
                    break;
                case 6:
                    this.Hide();
                    staticFormContainer.listaDeUsuarios.Show();
                    break;
            }
        }

        private void formaAdministracionUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
