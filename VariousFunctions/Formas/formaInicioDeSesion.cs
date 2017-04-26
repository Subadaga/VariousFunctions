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
            formaMenuPrincipal form2 = new formaMenuPrincipal();
            this.Hide();
            form2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
