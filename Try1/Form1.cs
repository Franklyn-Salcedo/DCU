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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=localhost; database=empresa; integrated security=true");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.Screen.Controls.Count > 0)
                this.Screen.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Screen.Controls.Add(fh);
            this.Screen.Tag = fh;
            fh.Show();

        }

     
          
        

        private void PacienteB_Click(object sender, EventArgs e)
        {

            AbrirFormEnPanel(new Form2());
        }

        private void ConsultaB_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Form_Consulta_());
           
        }

        private void Citasb_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Form_Citas_());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
