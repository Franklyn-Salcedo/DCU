using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try1
{
    public partial class Form_Consulta_ : Form
    {
        public Form_Consulta_()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=localhost; database=empresa; integrated security=true");

        private void llenar_grid()
        {

            string consulta = "Select * From clientes";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void vaciar_text()
        {

            textCodigo.Text = "";
            textNombre.Text = "";
            textApellido.Text = "";
            textDireccion.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            conexion.Open();
             
            string consulta = "select * from clientes where Codigo= " + textBox1.Text + "";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView2.DataSource = dt;
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            conexion.Close();
        }

        private void Form_Consulta__Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

   

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            textCodigo.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textNombre.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textApellido.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textDireccion.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string consulta = "update clientes set Codigo="+textCodigo.Text+",Nombre='"+textNombre.Text+ "' ,Apellido='"+textApellido.Text+ "', Direccion='"+textDireccion.Text+"' where Codigo='"+textCodigo.Text+"' ";
            SqlCommand commando = new SqlCommand(consulta, conexion);
            int cant;
            cant = commando.ExecuteNonQuery();
            if (cant > 0)
            {
                MessageBox.Show("Registro Modificado");
            }
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            conexion.Open();
            string consulta = "delete from clientes where codigo=" + textCodigo.Text+"";
            SqlCommand comando = new SqlCommand( consulta, conexion);
            comando.ExecuteNonQuery();
            llenar_grid();

            conexion.Close() ;

            vaciar_text();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
