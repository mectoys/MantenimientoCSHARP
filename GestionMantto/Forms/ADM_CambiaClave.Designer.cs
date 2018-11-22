namespace GestionMantto.Forms
{
    partial class ADM_CambiaClave
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
            this.btn2 = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.txtrepitaclave = new System.Windows.Forms.TextBox();
            this.txtnuevaclave = new System.Windows.Forms.TextBox();
            this.txtclaveactual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(196, 141);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 23;
            this.btn2.Text = "Cancelar";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(105, 141);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 22;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtrepitaclave
            // 
            this.txtrepitaclave.Location = new System.Drawing.Point(130, 85);
            this.txtrepitaclave.Name = "txtrepitaclave";
            this.txtrepitaclave.PasswordChar = '*';
            this.txtrepitaclave.Size = new System.Drawing.Size(100, 20);
            this.txtrepitaclave.TabIndex = 21;
            // 
            // txtnuevaclave
            // 
            this.txtnuevaclave.Location = new System.Drawing.Point(130, 52);
            this.txtnuevaclave.Name = "txtnuevaclave";
            this.txtnuevaclave.PasswordChar = '*';
            this.txtnuevaclave.Size = new System.Drawing.Size(100, 20);
            this.txtnuevaclave.TabIndex = 20;
            // 
            // txtclaveactual
            // 
            this.txtclaveactual.Location = new System.Drawing.Point(130, 12);
            this.txtclaveactual.Name = "txtclaveactual";
            this.txtclaveactual.PasswordChar = '*';
            this.txtclaveactual.Size = new System.Drawing.Size(100, 20);
            this.txtclaveactual.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Repita Nueva Clave :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ingrese Nueva Clave :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ingrese Clave Actual :";
            // 
            // ADM_CambiaClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 175);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.txtrepitaclave);
            this.Controls.Add(this.txtnuevaclave);
            this.Controls.Add(this.txtclaveactual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ADM_CambiaClave";
            this.Text = "ADM_CambiaClave";
            this.Load += new System.EventHandler(this.ADM_CambiaClave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.TextBox txtrepitaclave;
        private System.Windows.Forms.TextBox txtnuevaclave;
        private System.Windows.Forms.TextBox txtclaveactual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}