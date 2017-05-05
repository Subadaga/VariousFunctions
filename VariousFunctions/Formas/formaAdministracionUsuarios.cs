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
            }
        }
    }
}
