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
    public partial class FormCabanas : Form
    {
        public FormCabanas()
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

        private void ingresarProductosDeCabañasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductosCabana formulario = new formProductosCabana();
            this.Hide();
            formulario.Show();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            
            item.SubItems.Add(txtNumeroCabana.Text);
            item.SubItems.Add(txtCapacidad.Text);
            item.SubItems.Add(txtPrecio.Text);

            listView1.Items.Add(item);
                             
                
        }

        private void txtNumeroCabana_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCapacidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
        
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            this.txtCapacidad.Clear();
            this.txtNumeroCabana.Clear();
            this.txtPrecio.Clear();
       
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
