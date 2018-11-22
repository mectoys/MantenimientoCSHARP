namespace GestionMantto.Forms
{
    partial class ADM_Preview
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
            this.vistaprevia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vistaprevia)).BeginInit();
            this.SuspendLayout();
            // 
            // vistaprevia
            // 
            this.vistaprevia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vistaprevia.Location = new System.Drawing.Point(1, 2);
            this.vistaprevia.Name = "vistaprevia";
            this.vistaprevia.Size = new System.Drawing.Size(413, 362);
            this.vistaprevia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vistaprevia.TabIndex = 0;
            this.vistaprevia.TabStop = false;
            this.vistaprevia.Click += new System.EventHandler(this.vistaprevia_Click);
            // 
            // ADM_Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 365);
            this.Controls.Add(this.vistaprevia);
            this.KeyPreview = true;
            this.Name = "ADM_Preview";
            this.Text = "Vista Previa";
            this.Load += new System.EventHandler(this.ADM_Preview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vistaprevia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox vistaprevia;
    }
}