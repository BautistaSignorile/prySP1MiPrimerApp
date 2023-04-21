namespace prySP1MiPrimerApp
{
    partial class frmAlacenaPaginaDeAgregado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlacenaPaginaDeAgregado));
            this.mrcAgregadoDeProductos = new System.Windows.Forms.GroupBox();
            this.cmdConfirmar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.lstCantidad = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lstCatProductos = new System.Windows.Forms.ComboBox();
            this.textNombreDeProducto = new System.Windows.Forms.TextBox();
            this.lblNombreDeProducto = new System.Windows.Forms.Label();
            this.mrcAgregadoDeProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcAgregadoDeProductos
            // 
            this.mrcAgregadoDeProductos.Controls.Add(this.cmdConfirmar);
            this.mrcAgregadoDeProductos.Controls.Add(this.cmdCancelar);
            this.mrcAgregadoDeProductos.Controls.Add(this.lstCantidad);
            this.mrcAgregadoDeProductos.Controls.Add(this.lblCantidad);
            this.mrcAgregadoDeProductos.Controls.Add(this.lblCategoria);
            this.mrcAgregadoDeProductos.Controls.Add(this.lstCatProductos);
            this.mrcAgregadoDeProductos.Controls.Add(this.textNombreDeProducto);
            this.mrcAgregadoDeProductos.Controls.Add(this.lblNombreDeProducto);
            this.mrcAgregadoDeProductos.Location = new System.Drawing.Point(12, 12);
            this.mrcAgregadoDeProductos.Name = "mrcAgregadoDeProductos";
            this.mrcAgregadoDeProductos.Size = new System.Drawing.Size(275, 218);
            this.mrcAgregadoDeProductos.TabIndex = 0;
            this.mrcAgregadoDeProductos.TabStop = false;
            this.mrcAgregadoDeProductos.Text = "Agregado de productos";
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.Location = new System.Drawing.Point(175, 184);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(75, 23);
            this.cmdConfirmar.TabIndex = 7;
            this.cmdConfirmar.Text = "Confirmar";
            this.cmdConfirmar.UseVisualStyleBackColor = true;
            this.cmdConfirmar.Click += new System.EventHandler(this.cmdConfirmar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(25, 184);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 6;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // lstCantidad
            // 
            this.lstCantidad.FormattingEnabled = true;
            this.lstCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.lstCantidad.Location = new System.Drawing.Point(85, 109);
            this.lstCantidad.Name = "lstCantidad";
            this.lstCantidad.Size = new System.Drawing.Size(103, 21);
            this.lstCantidad.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(6, 109);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(68, 17);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(6, 73);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(73, 17);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lstCatProductos
            // 
            this.lstCatProductos.FormattingEnabled = true;
            this.lstCatProductos.Items.AddRange(new object[] {
            "Pereceredos",
            "No pereceredos",
            "Bebidas",
            "Gula"});
            this.lstCatProductos.Location = new System.Drawing.Point(85, 72);
            this.lstCatProductos.Name = "lstCatProductos";
            this.lstCatProductos.Size = new System.Drawing.Size(103, 21);
            this.lstCatProductos.TabIndex = 2;
            // 
            // textNombreDeProducto
            // 
            this.textNombreDeProducto.Location = new System.Drawing.Point(151, 37);
            this.textNombreDeProducto.Name = "textNombreDeProducto";
            this.textNombreDeProducto.Size = new System.Drawing.Size(100, 20);
            this.textNombreDeProducto.TabIndex = 1;
            // 
            // lblNombreDeProducto
            // 
            this.lblNombreDeProducto.AutoSize = true;
            this.lblNombreDeProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDeProducto.Location = new System.Drawing.Point(6, 37);
            this.lblNombreDeProducto.Name = "lblNombreDeProducto";
            this.lblNombreDeProducto.Size = new System.Drawing.Size(146, 17);
            this.lblNombreDeProducto.TabIndex = 0;
            this.lblNombreDeProducto.Text = "Nombre del Producto:";
            this.lblNombreDeProducto.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmAlacenaPaginaDeAgregado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 237);
            this.Controls.Add(this.mrcAgregadoDeProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlacenaPaginaDeAgregado";
            this.Text = "Alacena Pagina De Agregado";
            this.mrcAgregadoDeProductos.ResumeLayout(false);
            this.mrcAgregadoDeProductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcAgregadoDeProductos;
        private System.Windows.Forms.ComboBox lstCatProductos;
        private System.Windows.Forms.TextBox textNombreDeProducto;
        private System.Windows.Forms.Label lblNombreDeProducto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox lstCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button cmdConfirmar;
        private System.Windows.Forms.Button cmdCancelar;
    }
}