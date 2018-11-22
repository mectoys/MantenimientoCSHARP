namespace GestionMantto.Forms
{
    partial class ADM_TipoCambio
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
            this.label4 = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.LinkLabel();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.venta = new System.Windows.Forms.TextBox();
            this.compra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "Link para T.C. referencial";
            // 
            // link
            // 
            this.link.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.link.AutoSize = true;
            this.link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link.Location = new System.Drawing.Point(34, 169);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(122, 13);
            this.link.TabIndex = 114;
            this.link.TabStop = true;
            this.link.Text = "http://www.sbs.gob.pe/";
            // 
            // fecha
            // 
            this.fecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fecha.Enabled = false;
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(64, 16);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(100, 20);
            this.fecha.TabIndex = 113;
            // 
            // cancelar
            // 
            this.cancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelar.Location = new System.Drawing.Point(89, 106);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 111;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aceptar.Location = new System.Drawing.Point(5, 106);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 110;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "Fecha :";
            // 
            // venta
            // 
            this.venta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.venta.Location = new System.Drawing.Point(64, 76);
            this.venta.Name = "venta";
            this.venta.Size = new System.Drawing.Size(100, 20);
            this.venta.TabIndex = 108;
            // 
            // compra
            // 
            this.compra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.compra.Location = new System.Drawing.Point(64, 48);
            this.compra.Name = "compra";
            this.compra.Size = new System.Drawing.Size(100, 20);
            this.compra.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 109;
            this.label2.Text = "Venta :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 107;
            this.label1.Text = "Compra :";
            // 
            // ADM_TipoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 203);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.link);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.venta);
            this.Controls.Add(this.compra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ADM_TipoCambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADM_TipoCambio";
            this.Load += new System.EventHandler(this.ADM_TipoCambio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox venta;
        private System.Windows.Forms.TextBox compra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}