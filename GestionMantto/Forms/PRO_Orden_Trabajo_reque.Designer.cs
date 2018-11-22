namespace GestionMantto.Forms
{
    partial class PRO_Orden_Trabajo_reque
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
            this.consulta = new System.Windows.Forms.DataGridView();
            this.consultar = new System.Windows.Forms.Button();
            this.Hasta = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.desde = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // consulta
            // 
            this.consulta.AllowUserToAddRows = false;
            this.consulta.AllowUserToDeleteRows = false;
            this.consulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consulta.Location = new System.Drawing.Point(1, 68);
            this.consulta.Name = "consulta";
            this.consulta.ReadOnly = true;
            this.consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.consulta.Size = new System.Drawing.Size(617, 273);
            this.consulta.TabIndex = 1;
            // 
            // consultar
            // 
            this.consultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.consultar.Location = new System.Drawing.Point(540, 12);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(69, 32);
            this.consultar.TabIndex = 93;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // Hasta
            // 
            this.Hasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Hasta.Location = new System.Drawing.Point(388, 19);
            this.Hasta.Name = "Hasta";
            this.Hasta.Size = new System.Drawing.Size(80, 20);
            this.Hasta.TabIndex = 91;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(343, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 92;
            this.label21.Text = "Hasta :";
            // 
            // desde
            // 
            this.desde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desde.Location = new System.Drawing.Point(255, 19);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(80, 20);
            this.desde.TabIndex = 89;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(209, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 13);
            this.label23.TabIndex = 90;
            this.label23.Text = "Desde:";
            // 
            // PRO_Orden_Trabajo_reque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 346);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.Hasta);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.desde);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.consulta);
            this.KeyPreview = true;
            this.Name = "PRO_Orden_Trabajo_reque";
            this.Text = "PRO_Orden_Trabajo_reque";
            this.Load += new System.EventHandler(this.PRO_Orden_Trabajo_reque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView consulta;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.DateTimePicker Hasta;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker desde;
        private System.Windows.Forms.Label label23;
    }
}