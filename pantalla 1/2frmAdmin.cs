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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmInventarioAdministrador inventario = new frmInventarioAdministrador();
            inventario.ShowDialog();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            frmFacturaAdmin admin = new frmFacturaAdmin();
            admin.ShowDialog();
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            //Pendiente form de gráficos.
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            //Pendiente form de bitacora
        }

        private void buttcon_Click(object sender, EventArgs e)
        {
            Form formulario = new Formcon();
            formulario.Show();
        }
    }
}
