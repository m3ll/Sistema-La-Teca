using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloCaja_TCS
{
    public class Conexion
    {
        private String cadConexion = "Data Source=Arkarios-PC;Initial Catalog=TCS_HOTEL_C_LA_TECA;Integrated Security=True";
        private SqlConnection conn;

        public Conexion()
        {
            conn = new SqlConnection(cadConexion);
        }
        public String getCadConexion()
        {
            return cadConexion;
        }
        public SqlConnection getConexion() 
        {
            return conn;
        }
        public void abrirConexion()
        {
            try
            {
                conn.Open();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Conexion fallida" + ex.Errors);
                conn.Close();
            }
        }
        public void cerrarConexion()
        {
            try
            {
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Conexion fallida" + ex.Errors);

            }
        }
    }
}
