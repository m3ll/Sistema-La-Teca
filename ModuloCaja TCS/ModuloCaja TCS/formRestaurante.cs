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
    public partial class formRestaurante : Form
    {
        public formRestaurante()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMenuInventario formulario = new frmMenuInventario();
            this.Hide();
            formulario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuInventario formulario = new frmMenuInventario();
            this.Hide();
            formulario.Show();
        }

        private void inventaioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void añadirProductosAlInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductosRestaurante formulario = new FormProductosRestaurante();
            formulario.Show();
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBxIngredientes.Clear();
                this.txtIDProducto.Clear();
                    this.txtNombre.Clear();
                        this.txtPrecio.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();

            item.SubItems.Add(txtIDProducto.Text);
            item.SubItems.Add(txtNombre.Text);
            item.SubItems.Add(cboxTipo.Text);
            item.SubItems.Add(txtPrecio.Text);
            item.SubItems.Add(txtBxIngredientes.Text);

            listView1.Items.Add(item);
        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }
    }
}
