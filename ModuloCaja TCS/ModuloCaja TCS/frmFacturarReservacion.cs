using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloCaja_TCS
{
    public partial class frmFacturarReservacion : Form
    {
        private Conexion conexion;
        public frmFacturarReservacion()
        {
            InitializeComponent();
            conexion = new Conexion();
            DateTime dia = DateTime.Now;
            txtFecha.Text = Convert.ToString(dia);
        }

        private void txtNumeroReservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
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
