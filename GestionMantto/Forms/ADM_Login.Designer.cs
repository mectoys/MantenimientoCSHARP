namespace GestionMantto.Forms
{
    partial class ADM_Login
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
            this.empresa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clave = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // empresa
            // 
            this.empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresa.FormattingEnabled = true;
            this.empresa.ItemHeight = 13;
            this.empresa.Location = new System.Drawing.Point(100, 113);
            this.empresa.Name = "empresa";
            this.empresa.Size = new System.Drawing.Size(152, 21);
            this.empresa.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Empresa :";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.Color.Chocolate;
            this.nombre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.White;
            this.nombre.Location = new System.Drawing.Point(27, 9);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(33, 20);
            this.nombre.TabIndex = 54;
            this.nombre.Text = "----";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(249, 157);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 51;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(154, 157);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 50;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Contraseña :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Usuario :";
            // 
            // clave
            // 
            this.clave.Location = new System.Drawing.Point(95, 77);
            this.clave.Name = "clave";
            this.clave.PasswordChar = '*';
            this.clave.Size = new System.Drawing.Size(100, 20);
            this.clave.TabIndex = 49;
            this.clave.WordWrap = false;
            this.clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clave_KeyPress);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(95, 41);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 20);
            this.user.TabIndex = 48;
            this.user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_KeyPress);
            // 
            // ADM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 187);
            this.Controls.Add(this.empresa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.user);
            this.Name = "ADM_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADM_Login";
            this.Load += new System.EventHandler(this.ADM_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox empresa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clave;
        private System.Windows.Forms.TextBox user;
    }
}