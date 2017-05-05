using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

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
                if (operations.comparacionContrasenas(fillCuenta.Text, fillContrasena.Text))
                {
                    if (operations.obtenerNumeroIntentos(fillCuenta.Text) < Convert.ToInt32(ConfigurationSettings.AppSettings["maxPassWordAttemps"]))
                    {
                        this.Hide();
                        staticFormContainer.formaMenu.Show();
                        operations.modificarAtributo(fillCuenta.Text, 9, DateTime.Now.ToLongDateString() + "," + DateTime.Now.ToLongTimeString());
                        operations.modificarAtributo(fillCuenta.Text, 11, "0");
                    }
                    else
                    {
                        MessageBox.Show("Esta cuenta esta bloqueada");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario o contraseña no existen");
                    int intentos = operations.obtenerNumeroIntentos(fillCuenta.Text) + 1;
                    operations.modificarAtributo(fillCuenta.Text, 11, intentos.ToString());
                    if (intentos >= Convert.ToInt32(ConfigurationSettings.AppSettings["maxPassWordAttemps"]))
                    {
                        operations.modificarAtributo(fillCuenta.Text, 8, "true");
                        MessageBox.Show("Su cuenta ha sido bloqueada");
                    }

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

        private void fillContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void formaInicioDeSesion_Load(object sender, EventArgs e)
        {
            fillContrasena.PasswordChar = '*';
        }
    }
}
