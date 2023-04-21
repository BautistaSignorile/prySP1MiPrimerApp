using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySP1MiPrimerApp
{
    public partial class frmAlacenaPaginaDeAgregado : Form
    {
        public frmAlacenaPaginaDeAgregado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            Form Pagina2 = new frmListado();
            Pagina2.Show();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Form Regresar = new frmAlacena();
            Regresar.Show();
        }
    }
}
