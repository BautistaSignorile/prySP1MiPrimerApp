﻿namespace prySP1MiPrimerApp
{
    partial class frmAlacena
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
            this.cmdAgregarProducto = new System.Windows.Forms.Button();
            this.mrcOrganizadorDeAlacena = new System.Windows.Forms.GroupBox();
            this.mrcOrganizadorDeAlacena.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdAgregarProducto
            // 
            this.cmdAgregarProducto.Font = new System.Drawing.Font("Wide Latin", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregarProducto.Location = new System.Drawing.Point(34, 68);
            this.cmdAgregarProducto.Name = "cmdAgregarProducto";
            this.cmdAgregarProducto.Size = new System.Drawing.Size(171, 73);
            this.cmdAgregarProducto.TabIndex = 0;
            this.cmdAgregarProducto.Text = "Agregar Producto";
            this.cmdAgregarProducto.UseVisualStyleBackColor = true;
            this.cmdAgregarProducto.Click += new System.EventHandler(this.cmdAgregarProducto_Click);
            // 
            // mrcOrganizadorDeAlacena
            // 
            this.mrcOrganizadorDeAlacena.Controls.Add(this.cmdAgregarProducto);
            this.mrcOrganizadorDeAlacena.Location = new System.Drawing.Point(12, 12);
            this.mrcOrganizadorDeAlacena.Name = "mrcOrganizadorDeAlacena";
            this.mrcOrganizadorDeAlacena.Size = new System.Drawing.Size(247, 198);
            this.mrcOrganizadorDeAlacena.TabIndex = 1;
            this.mrcOrganizadorDeAlacena.TabStop = false;
            this.mrcOrganizadorDeAlacena.Text = "Organizador de alacena";
            this.mrcOrganizadorDeAlacena.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 231);
            this.Controls.Add(this.mrcOrganizadorDeAlacena);
            this.Name = "frmAlacena";
            this.Text = "frmAlacena";
            this.Load += new System.EventHandler(this.frmAlacena_Load);
            this.mrcOrganizadorDeAlacena.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAgregarProducto;
        private System.Windows.Forms.GroupBox mrcOrganizadorDeAlacena;
    }
}