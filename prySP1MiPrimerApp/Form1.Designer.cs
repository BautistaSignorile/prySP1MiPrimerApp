namespace prySP1MiPrimerApp
{
    partial class frm_principal
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.cboIngreseCategoriaDeGasto = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIngresoDeDatos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mrcAppRegistroMensual = new System.Windows.Forms.GroupBox();
            this.mrcDatos.SuspendLayout();
            this.mrcAppRegistroMensual.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.cboIngreseCategoriaDeGasto);
            this.mrcDatos.Controls.Add(this.button2);
            this.mrcDatos.Controls.Add(this.button1);
            this.mrcDatos.Controls.Add(this.textBox1);
            this.mrcDatos.Controls.Add(this.label2);
            this.mrcDatos.Controls.Add(this.lblIngresoDeDatos);
            this.mrcDatos.Location = new System.Drawing.Point(17, 92);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(328, 291);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(19, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "BORRAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(187, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "CONFIRMAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese categoria de gasto:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(157, 455);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Deposito:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // mrcAppRegistroMensual
            // 
            this.mrcAppRegistroMensual.Controls.Add(this.textBox2);
            this.mrcAppRegistroMensual.Controls.Add(this.label1);
            this.mrcAppRegistroMensual.Controls.Add(this.textBox3);
            this.mrcAppRegistroMensual.Controls.Add(this.label3);
            this.mrcAppRegistroMensual.Controls.Add(this.mrcDatos);
            this.mrcAppRegistroMensual.Location = new System.Drawing.Point(12, 12);
            this.mrcAppRegistroMensual.Name = "mrcAppRegistroMensual";
            this.mrcAppRegistroMensual.Size = new System.Drawing.Size(360, 513);
            this.mrcAppRegistroMensual.TabIndex = 0;
            this.mrcAppRegistroMensual.TabStop = false;
            this.mrcAppRegistroMensual.Text = "App Registro Mensual";
            this.mrcAppRegistroMensual.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(377, 531);
            this.Controls.Add(this.mrcAppRegistroMensual);
            this.Name = "frm_principal";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIngresoDeDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox mrcAppRegistroMensual;
    }
}

