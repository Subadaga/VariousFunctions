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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    panelBajaUsuarios.Visible = false;
                    panelAltaUsuarios.Visible = true;                   
                    break;
                case 1:
                    panelAltaUsuarios.Visible = false;
                    panelBajaUsuarios.Visible = true;
                    break;
            }
        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            staticFormContainer.formaMenu.Show();
        }
    }
}
