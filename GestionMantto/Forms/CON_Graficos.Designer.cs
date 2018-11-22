namespace GestionMantto.Forms
{
    partial class CON_Graficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cerrar = new System.Windows.Forms.Button();
            this.consulta = new System.Windows.Forms.DataGridView();
            this.Barras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.equipo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Tienda = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barras)).BeginInit();
            this.SuspendLayout();
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Location = new System.Drawing.Point(773, 469);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 27);
            this.cerrar.TabIndex = 9;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            // 
            // consulta
            // 
            this.consulta.AllowUserToAddRows = false;
            this.consulta.AllowUserToDeleteRows = false;
            this.consulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consulta.Location = new System.Drawing.Point(0, 203);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(848, 75);
            this.consulta.TabIndex = 8;
            // 
            // Barras
            // 
            chartArea2.Name = "ChartArea1";
            this.Barras.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Barras.Legends.Add(legend2);
            this.Barras.Location = new System.Drawing.Point(12, 306);
            this.Barras.Name = "Barras";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Barras.Series.Add(series2);
            this.Barras.Size = new System.Drawing.Size(461, 284);
            this.Barras.TabIndex = 10;
            this.Barras.Text = "chart1";
            // 
            // equipo
            // 
            this.equipo.FormattingEnabled = true;
            this.equipo.Location = new System.Drawing.Point(67, 65);
            this.equipo.Name = "equipo";
            this.equipo.Size = new System.Drawing.Size(367, 21);
            this.equipo.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 78;
            this.label12.Text = "Equipo :";
            // 
            // Tienda
            // 
            this.Tienda.FormattingEnabled = true;
            this.Tienda.Location = new System.Drawing.Point(67, 38);
            this.Tienda.Name = "Tienda";
            this.Tienda.Size = new System.Drawing.Size(426, 21);
            this.Tienda.TabIndex = 75;
            this.Tienda.SelectionChangeCommitted += new System.EventHandler(this.ubicacion_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Tienda :";
            // 
            // clientes
            // 
            this.clientes.FormattingEnabled = true;
            this.clientes.Location = new System.Drawing.Point(67, 12);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(426, 21);
            this.clientes.TabIndex = 73;
            this.clientes.SelectionChangeCommitted += new System.EventHandler(this.clientes_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Cliente :";
            // 
            // CON_Graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 602);
            this.Controls.Add(this.equipo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Tienda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Barras);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.consulta);
            this.Name = "CON_Graficos";
            this.Text = "CON_Graficos";
            this.Load += new System.EventHandler(this.CON_Graficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.DataGridView consulta;
        private System.Windows.Forms.DataVisualization.Charting.Chart Barras;
        private System.Windows.Forms.ComboBox equipo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Tienda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox clientes;
        private System.Windows.Forms.Label label1;
    }
}