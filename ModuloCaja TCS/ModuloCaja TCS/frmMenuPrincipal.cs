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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
            frmLogin login = new frmLogin();
            this.Hide();

            login.ShowDialog();


            
        }

        private void btnRestaurante_Click(object sender, EventArgs e)
        {

            Restaurante.Restaurante restaurante = new Restaurante.Restaurante();
            restaurante.Show();
            this.Hide();
        }

        private void btnCajas_Click(object sender, EventArgs e)
        {
            frmMenuFacturacion frmMenuFacturas = new frmMenuFacturacion();
            frmMenuFacturas.Show();
            this.Hide();
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            Reservaciones.Menu menuReservaciones = new Reservaciones.Menu();
            menuReservaciones.Show();
            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Sistema_de_inventario.frmMenuInventario menuInventario = new Sistema_de_inventario.frmMenuInventario();
            menuInventario.Show();
            this.Hide();
        }
    }
}
