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
        string varNombreDelProducto;
        string varCategoria;
        int varCantidad;
        public frmAlacenaPaginaDeAgregado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            varNombreDelProducto = txtNombreDeProducto.Text;
            varCantidad = Convert.ToInt32(lstCantidad.Text);
            varCategoria = lstCatProductos.Text;
            lstAlacena.Items.Add(varNombreDelProducto + " " +  varCategoria + " " + varCantidad);
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void lstAlacena_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
