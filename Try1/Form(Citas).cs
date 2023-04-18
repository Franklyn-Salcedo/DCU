using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Try1
{
    public partial class Form_Citas_ : Form
    {
        public Form_Citas_()
        {
            InitializeComponent();
        }

    
        Categoria cat = new Categoria();
       
        private void Form_Citas__Load(object sender, EventArgs e)
        {


            NClientes.DataSource = cat.CargarCombo();
            NClientes.DisplayMember = "Nombre";
            NClientes.ValueMember = "Codigo";

     
        }

    

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        SqlConnection conexion = new SqlConnection("server=localhost; database=empresa; integrated security=true");
        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = " insert into citas values('" + NClientes.Text + "','" + Fecha.Text + "','" + Gmail.Text + "','" + Razon.Text + "') ";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro Agregado");

            conexion.Close();
        }

        private void NClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
