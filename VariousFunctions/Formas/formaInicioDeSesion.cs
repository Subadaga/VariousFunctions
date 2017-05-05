using System;
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
    public partial class formaInicioDeSesion : Form
    {

        
        public formaInicioDeSesion()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (operations.userExists(fillCuenta.Text))
             {
                 if(operations.comparacionContrasenas(fillCuenta.Text, fillContrasena.Text))
                 {
                     this.Hide();
                     staticFormContainer.formaMenu.Show();
                }
                else
                {
                    MessageBox.Show("El usuario o contraseña no existen");
                }
             }
             else
             {
                 MessageBox.Show("El usuario o contraseña no existen");
             }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
