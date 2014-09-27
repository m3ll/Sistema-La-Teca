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
    public partial class frmMenuFacturacion : Form
    {
        public frmMenuFacturacion()
        {
            InitializeComponent();
        }

        private void btnFacturarRestaurate_Click(object sender, EventArgs e)
        {
            frmFacturarRestaurante frmFacturaRestaurante = new frmFacturarRestaurante();
            frmFacturaRestaurante.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmPrincipal = new frmMenuPrincipal();
            frmPrincipal.Show();
            this.Close();
            this.Dispose();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmInformesFacturas frmInforme = new frmInformesFacturas();
            frmInforme.Show();
            this.Hide();
        }

        private void btnFacturarReservacion_Click(object sender, EventArgs e)
        {
            frmFacturarReservacion frmFacturaReservacion = new frmFacturarReservacion();
            frmFacturaReservacion.Show();
            this.Hide();
            
        }
    }
}
