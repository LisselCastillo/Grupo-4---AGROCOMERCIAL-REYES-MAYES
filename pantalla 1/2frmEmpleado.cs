using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pantalla_1
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void pantalla_2_Load(object sender, EventArgs e)
        {

        }

        private void btnInvent_Click(object sender, EventArgs e)
        {
            frmInventarioEmpleado inventario = new frmInventarioEmpleado();
            inventario.ShowDialog();
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            frmFacturaAdmin factura = new frmFacturaAdmin();
            factura.ShowDialog();
        }
    }
}
