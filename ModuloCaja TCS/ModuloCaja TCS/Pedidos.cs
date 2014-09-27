using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
         }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Restaurante volver = new Restaurante();
            volver.Show();
            this.Hide();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Restaurante volver = new Restaurante();
            volver.Show();
            this.Hide();
        }

        private void btnGuarnicion_Click(object sender, EventArgs e)
        {

        }

        private void btnCambiarMesa_Click(object sender, EventArgs e)
        {
            CambiarMesa cambiar = new CambiarMesa();
            cambiar.Show();
            this.Hide();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Ordenar nueva = new Ordenar();
            nueva.Show();
            this.Hide();
        }
    }
}
