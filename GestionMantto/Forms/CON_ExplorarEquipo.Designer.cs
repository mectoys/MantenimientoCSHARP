namespace GestionMantto.Forms
{
    partial class CON_ExplorarEquipo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CON_ExplorarEquipo));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Clientes = new System.Windows.Forms.ComboBox();
            this.DataReque = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataReque)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(12, 44);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(249, 400);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Tienda16.png");
            this.imageList1.Images.SetKeyName(1, "Engine16.png");
            this.imageList1.Images.SetKeyName(2, "work16.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Cliente :";
            // 
            // Clientes
            // 
            this.Clientes.FormattingEnabled = true;
            this.Clientes.Location = new System.Drawing.Point(57, 12);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(314, 21);
            this.Clientes.TabIndex = 47;
            this.Clientes.SelectedIndexChanged += new System.EventHandler(this.Clientes_SelectedIndexChanged);
            // 
            // DataReque
            // 
            this.DataReque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataReque.Location = new System.Drawing.Point(267, 44);
            this.DataReque.Name = "DataReque";
            this.DataReque.Size = new System.Drawing.Size(521, 224);
            this.DataReque.TabIndex = 49;
            // 
            // CON_ExplorarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataReque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clientes);
            this.Controls.Add(this.treeView1);
            this.Name = "CON_ExplorarEquipo";
            this.Text = "Explorador de Equipo";
            this.Load += new System.EventHandler(this.CON_ExplorarEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataReque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Clientes;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView DataReque;
    }
}