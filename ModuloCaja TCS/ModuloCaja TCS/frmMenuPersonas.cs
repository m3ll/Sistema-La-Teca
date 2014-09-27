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
    public partial class frmMenuPersonas : Form
    {
        public frmMenuPersonas()
        {
            InitializeComponent();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmPrincipal=new frmMenuPrincipal();
            frmPrincipal.Show();
            this.Close();
            this.Dispose();
        }
    }
}
