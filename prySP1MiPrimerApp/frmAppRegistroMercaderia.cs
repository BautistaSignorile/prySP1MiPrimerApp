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
    public partial class frmPrincipal : Form
    {
        decimal varDeposito = 0;
        decimal varGastos = 0;
        decimal varSaldo = 0;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            varDeposito = 0;
            varSaldo = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            varGastos = 0;
        }
        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            varDeposito = Convert.ToDecimal(textDeposito.Text);
            varGastos = Convert.ToDecimal(txtIngresoGastos.Text);
            
            varSaldo = varDeposito - varGastos;
            txtSaldo.Text = varSaldo.ToString();
        }
    }
}
