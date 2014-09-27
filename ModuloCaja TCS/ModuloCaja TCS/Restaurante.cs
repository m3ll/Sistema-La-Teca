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
    public partial class Restaurante : Form
    {
        public Restaurante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            Pedidos abrir = new Pedidos();
            abrir.Show();
            this.Hide();

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void platillosYBebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Platos abrir2 = new Platos();
            abrir2.Show();
            this.Hide();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnMesa1_Click_1(object sender, EventArgs e)
        {
            Pedidos abrir = new Pedidos();
            abrir.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Restaurante_Load(object sender, EventArgs e)
        {
            ToolTip mensaje = new ToolTip();
            mensaje.AutomaticDelay = 5000;
            mensaje.InitialDelay = 1000;
            mensaje.ReshowDelay = 500;
            mensaje.ShowAlways = true;
            mensaje.SetToolTip(this.btnMesa1, "Ingresar a la mesa número 1");
            mensaje.SetToolTip(this.btnMesa2, "Ingresar a la mesa número 2");
            mensaje.SetToolTip(this.btnMesa3, "Ingresar a la mesa número 3");
            mensaje.SetToolTip(this.btnMesa4, "Ingresar a la mesa número 4");
            mensaje.SetToolTip(this.btnMesa5, "Ingresar a la mesa número 5");
            mensaje.SetToolTip(this.btnMesa6, "Ingresar a la mesa número 6");
            mensaje.SetToolTip(this.btnMesa7, "Ingresar a la mesa número 7");
            mensaje.SetToolTip(this.btnMesa8, "Ingresar a la mesa número 8");
            mensaje.SetToolTip(this.btnMesa9, "Ingresar a la mesa número 9");
            mensaje.SetToolTip(this.btnMesa10, "Ingresar a la mesa número 10");
            mensaje.SetToolTip(this.btnBarra, "Ingresar a la barra");
            mensaje.SetToolTip(this.menuStrip1, "Mantenimiento de las bebidas y platillos");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuloCaja_TCS.frmMenuPrincipal regresar = new ModuloCaja_TCS.frmMenuPrincipal();
            regresar.Show();
            this.Close();


        }
    }
}
