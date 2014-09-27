using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_inventario
{
    public partial class frmMenuInventario : Form
    {
        public frmMenuInventario()
        {
            InitializeComponent();
        }

        private void btnInventarioRest_Click(object sender, EventArgs e)
        {
            formRestaurante formulario = new formRestaurante();
            this.Hide();
            formulario.Show();
        }

        private void btnInventarioCabana_Click(object sender, EventArgs e)
        {
            FormCabanas formulario = new FormCabanas();
            this.Hide();
            formulario.Show();
        }

        private void sALIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            ModuloCaja_TCS.frmMenuPrincipal menuPrincipal = new ModuloCaja_TCS.frmMenuPrincipal();
            menuPrincipal.Show();
        }

        
    }
}
