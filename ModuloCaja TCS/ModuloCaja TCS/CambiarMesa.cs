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
    public partial class CambiarMesa : Form
    {
        public CambiarMesa()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Regresar");
            Pedidos volver = new Pedidos();
            volver.Show();
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
