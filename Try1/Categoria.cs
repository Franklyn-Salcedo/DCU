using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try1
{
    public class Categoria
    {
        Conexion cn = new Conexion();

        public DataTable CargarCombo()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_CargarComboBox", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


    }
}
