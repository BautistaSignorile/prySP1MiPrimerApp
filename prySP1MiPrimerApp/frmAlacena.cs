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
    public partial class frmAlacena : Form
    {
        public frmAlacena()
        {
            InitializeComponent();
        }

        private void cmdAgregarProducto_Click(object sender, EventArgs e)
        {
            Form Pagina2 = new frmAlacenaPaginaDeAgregado();
            Pagina2.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAlacena_Load(object sender, EventArgs e)
        {

        }
    }
}
