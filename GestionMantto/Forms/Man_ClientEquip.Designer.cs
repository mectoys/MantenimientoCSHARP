namespace GestionMantto.Forms
{
    partial class Man_ClientEquip
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
            this.cancelar = new System.Windows.Forms.Button();
            this.add4 = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            this.ConTiendaEquipo = new System.Windows.Forms.DataGridView();
            this.SinTiendaEquipo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.clientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tienda = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConTiendaEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinTiendaEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(762, 423);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 45;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // add4
            // 
            this.add4.Location = new System.Drawing.Point(399, 278);
            this.add4.Name = "add4";
            this.add4.Size = new System.Drawing.Size(53, 24);
            this.add4.TabIndex = 44;
            this.add4.Text = "<<";
            this.add4.UseVisualStyleBackColor = true;
            this.add4.Click += new System.EventHandler(this.add4_Click);
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(399, 174);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(53, 24);
            this.add2.TabIndex = 43;
            this.add2.Text = ">>";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            // 
            // ConTiendaEquipo
            // 
            this.ConTiendaEquipo.AllowUserToAddRows = false;
            this.ConTiendaEquipo.AllowUserToDeleteRows = false;
            this.ConTiendaEquipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ConTiendaEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConTiendaEquipo.Location = new System.Drawing.Point(457, 105);
            this.ConTiendaEquipo.Name = "ConTiendaEquipo";
            this.ConTiendaEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConTiendaEquipo.Size = new System.Drawing.Size(380, 312);
            this.ConTiendaEquipo.TabIndex = 42;
            // 
            // SinTiendaEquipo
            // 
            this.SinTiendaEquipo.AllowUserToAddRows = false;
            this.SinTiendaEquipo.AllowUserToDeleteRows = false;
            this.SinTiendaEquipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SinTiendaEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SinTiendaEquipo.Location = new System.Drawing.Point(10, 105);
            this.SinTiendaEquipo.Name = "SinTiendaEquipo";
            this.SinTiendaEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SinTiendaEquipo.Size = new System.Drawing.Size(382, 312);
            this.SinTiendaEquipo.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Cliente :";
            // 
            // clientes
            // 
            this.clientes.FormattingEnabled = true;
            this.clientes.Location = new System.Drawing.Point(65, 6);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(336, 21);
            this.clientes.TabIndex = 39;
            this.clientes.SelectionChangeCommitted += new System.EventHandler(this.clientes_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Listado Equipos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Equipos en Tienda";
            // 
            // Tienda
            // 
            this.Tienda.FormattingEnabled = true;
            this.Tienda.Location = new System.Drawing.Point(65, 33);
            this.Tienda.Name = "Tienda";
            this.Tienda.Size = new System.Drawing.Size(336, 21);
            this.Tienda.TabIndex = 68;
            this.Tienda.SelectedIndexChanged += new System.EventHandler(this.Tienda_SelectedIndexChanged);
            this.Tienda.SelectionChangeCommitted += new System.EventHandler(this.Tienda_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Tienda :";
            // 
            // Man_ClientEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 454);
            this.Controls.Add(this.Tienda);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.add4);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.ConTiendaEquipo);
            this.Controls.Add(this.SinTiendaEquipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientes);
            this.Name = "Man_ClientEquip";
            this.Text = "Cliente con Equipos";
            this.Load += new System.EventHandler(this.Man_ClientEquip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConTiendaEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinTiendaEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button add4;
        private System.Windows.Forms.Button add2;
        private System.Windows.Forms.DataGridView ConTiendaEquipo;
        private System.Windows.Forms.DataGridView SinTiendaEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox clientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Tienda;
        private System.Windows.Forms.Label label9;
    }
}