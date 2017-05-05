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
    public partial class listaDeUsuarios : Form
    {
        public listaDeUsuarios()
        {
            InitializeComponent();
        }

        private void listaDeUsuarios_Load(object sender, EventArgs e)
        {
            string filePath = (System.IO.Directory.GetCurrentDirectory().ToString() + @"\Users.xml");

            usuariosDataSet.ReadXml(filePath);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = usuariosDataSet;
            dataGridView1.DataMember = "User";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            staticFormContainer.formaAdminUsuarios.Show();
        }
    }
}
