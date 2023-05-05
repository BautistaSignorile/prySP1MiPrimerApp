namespace prySP1MiPrimerApp
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.cboIngreseCategoriaDeGasto = new System.Windows.Forms.ComboBox();
            this.txtIngresoGastos = new System.Windows.Forms.TextBox();
            this.lblIngreseCategoriaDeGasto = new System.Windows.Forms.Label();
            this.lblIngresoDeDatos = new System.Windows.Forms.Label();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdConfirmar = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.textDeposito = new System.Windows.Forms.TextBox();
            this.mrcAppRegistroMensual = new System.Windows.Forms.GroupBox();
            this.mrcDatos.SuspendLayout();
            this.mrcAppRegistroMensual.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.cboIngreseCategoriaDeGasto);
            this.mrcDatos.Controls.Add(this.txtIngresoGastos);
            this.mrcDatos.Controls.Add(this.lblIngreseCategoriaDeGasto);
            this.mrcDatos.Controls.Add(this.lblIngresoDeDatos);
            this.mrcDatos.Location = new System.Drawing.Point(17, 92);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(309, 96);
            this.mrcDatos.TabIndex = 0;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "DATOS";
            // 
            // cboIngreseCategoriaDeGasto
            // 
            this.cboIngreseCategoriaDeGasto.FormattingEnabled = true;
            this.cboIngreseCategoriaDeGasto.Items.AddRange(new object[] {
            "Alquiler",
            "Alimentos",
            "Entretenimiento",
            "Luz",
            "Gas",
            "Internet"});
            this.cboIngreseCategoriaDeGasto.Location = new System.Drawing.Point(158, 66);
            this.cboIngreseCategoriaDeGasto.Name = "cboIngreseCategoriaDeGasto";
            this.cboIngreseCategoriaDeGasto.Size = new System.Drawing.Size(107, 21);
            this.cboIngreseCategoriaDeGasto.TabIndex = 6;
            // 
            // txtIngresoGastos
            // 
            this.txtIngresoGastos.Location = new System.Drawing.Point(101, 30);
            this.txtIngresoGastos.Name = "txtIngresoGastos";
            this.txtIngresoGastos.Size = new System.Drawing.Size(89, 20);
            this.txtIngresoGastos.TabIndex = 2;
            // 
            // lblIngreseCategoriaDeGasto
            // 
            this.lblIngreseCategoriaDeGasto.AutoSize = true;
            this.lblIngreseCategoriaDeGasto.Location = new System.Drawing.Point(16, 69);
            this.lblIngreseCategoriaDeGasto.Name = "lblIngreseCategoriaDeGasto";
            this.lblIngreseCategoriaDeGasto.Size = new System.Drawing.Size(136, 13);
            this.lblIngreseCategoriaDeGasto.TabIndex = 1;
            this.lblIngreseCategoriaDeGasto.Text = "Ingrese categoria de gasto:";
            // 
            // lblIngresoDeDatos
            // 
            this.lblIngresoDeDatos.AutoSize = true;
            this.lblIngresoDeDatos.Location = new System.Drawing.Point(16, 33);
            this.lblIngresoDeDatos.Name = "lblIngresoDeDatos";
            this.lblIngresoDeDatos.Size = new System.Drawing.Size(79, 13);
            this.lblIngresoDeDatos.TabIndex = 0;
            this.lblIngresoDeDatos.Text = "Ingrese gastos:";
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.BackColor = System.Drawing.Color.IndianRed;
            this.cmdBorrar.Location = new System.Drawing.Point(37, 194);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(121, 37);
            this.cmdBorrar.TabIndex = 5;
            this.cmdBorrar.Text = "BORRAR";
            this.cmdBorrar.UseVisualStyleBackColor = false;
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdConfirmar.Location = new System.Drawing.Point(205, 194);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(121, 37);
            this.cmdConfirmar.TabIndex = 4;
            this.cmdConfirmar.Text = "CONFIRMAR";
            this.cmdConfirmar.UseVisualStyleBackColor = false;
            this.cmdConfirmar.Click += new System.EventHandler(this.cmdConfirmar_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(113, 249);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(156, 246);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(89, 20);
            this.txtSaldo.TabIndex = 4;
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Location = new System.Drawing.Point(32, 53);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(52, 13);
            this.lblDeposito.TabIndex = 7;
            this.lblDeposito.Text = "Deposito:";
            // 
            // textDeposito
            // 
            this.textDeposito.Location = new System.Drawing.Point(90, 50);
            this.textDeposito.Name = "textDeposito";
            this.textDeposito.Size = new System.Drawing.Size(89, 20);
            this.textDeposito.TabIndex = 8;
            this.textDeposito.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // mrcAppRegistroMensual
            // 
            this.mrcAppRegistroMensual.Controls.Add(this.textDeposito);
            this.mrcAppRegistroMensual.Controls.Add(this.cmdBorrar);
            this.mrcAppRegistroMensual.Controls.Add(this.lblDeposito);
            this.mrcAppRegistroMensual.Controls.Add(this.cmdConfirmar);
            this.mrcAppRegistroMensual.Controls.Add(this.txtSaldo);
            this.mrcAppRegistroMensual.Controls.Add(this.lblSaldo);
            this.mrcAppRegistroMensual.Controls.Add(this.mrcDatos);
            this.mrcAppRegistroMensual.Location = new System.Drawing.Point(12, 12);
            this.mrcAppRegistroMensual.Name = "mrcAppRegistroMensual";
            this.mrcAppRegistroMensual.Size = new System.Drawing.Size(360, 274);
            this.mrcAppRegistroMensual.TabIndex = 0;
            this.mrcAppRegistroMensual.TabStop = false;
            this.mrcAppRegistroMensual.Text = "App Registro Mensual";
            this.mrcAppRegistroMensual.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(377, 290);
            this.Controls.Add(this.mrcAppRegistroMensual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "App de Registro Mensual";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.mrcAppRegistroMensual.ResumeLayout(false);
            this.mrcAppRegistroMensual.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.ComboBox cboIngreseCategoriaDeGasto;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdConfirmar;
        private System.Windows.Forms.TextBox txtIngresoGastos;
        private System.Windows.Forms.Label lblIngreseCategoriaDeGasto;
        private System.Windows.Forms.Label lblIngresoDeDatos;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.TextBox textDeposito;
        private System.Windows.Forms.GroupBox mrcAppRegistroMensual;
    }
}

