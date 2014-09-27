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

namespace ModuloCaja_TCS
{
    public partial class frmFacturarRestaurante : Form
    {
      private  Conexion conexion;
      SqlCommand comando;
      SqlDataAdapter dataAdapter;
        public frmFacturarRestaurante()
        {
            
            InitializeComponent();
            DateTime dia = DateTime.Now;
            txtFecha.Text = Convert.ToString(dia);
         conexion = new Conexion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtImpuesto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numeroMesa = 0;
            numeroMesa = Convert.ToInt32(txtNumeroMesa.Text);
            conexion.abrirConexion();
         /*   SqlCommand comando = new SqlCommand("Select num_factura from TCSH_FACTURA" +
"inner join TCST_DETALLE_FACTURA as detalle" +
"ON num_factura= detalle.num_factura " +
"join TCSF_MESA as mesa on detalle.id_mesa = mesa.id_mesa" +
"where mesa.id_mesa" + numeroMesa, conexion.getConexion());*/
             comando= new SqlCommand("select num_factura from TCSH_FACTURA,TCSF_MESA where id_mesa=" + numeroMesa,conexion.getConexion());
            dataAdapter = new SqlDataAdapter(comando);
            SqlDataReader lecturaSQL;
            try
            {
                lecturaSQL = comando.ExecuteReader();
                while (lecturaSQL.Read())
                {
                    txtNumeroFactura.Text = Convert.ToString(lecturaSQL["num_factura"]);
                }
                lecturaSQL.Close();
           cargarDataGrieView();
                conexion.cerrarConexion();
            }

            catch (SqlException er)
            {
                MessageBox.Show(er.Message);
            }


        }//fin del metodo buscar
        private void cargarDataGrieView()
        {//inicio
            DataTable dtDatosFactura = new DataTable();
            comando=new SqlCommand("Select * from vFacturaRestaurante",conexion.getConexion());
            dataAdapter=new SqlDataAdapter(comando);
            dataAdapter.Fill(dtDatosFactura);
        dgvFactura.DataSource= dtDatosFactura;
        }//fin
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir imprimir = new Imprimir();
            imprimir.Show();
        }

        private void FacturarRestaurante_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenuFacturacion frmMenuFacturacion = new frmMenuFacturacion();
            frmMenuFacturacion.Show();
            this.Close();
            this.Dispose();
        }
    }
}
