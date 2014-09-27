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
    public partial class FormProductosRestaurante : Form
    {
        public FormProductosRestaurante()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formRestaurante formulario = new formRestaurante();
            this.Hide();    
            formulario.Show();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRestaurante formulario = new formRestaurante();
            this.Hide();
            formulario.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtCantidad.Clear();
            this.txtCodigo.Clear();
        }
    }
}
