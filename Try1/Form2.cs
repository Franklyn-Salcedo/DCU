using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=localhost; database=empresa; integrated security=true");

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = " insert into clientes values("+textBox1.Text+",'"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"') ";
            SqlCommand cmd = new SqlCommand(consulta,conexion);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro Agregado");

            conexion.Close();
        }
    }
}
