namespace GestionMantto.Forms
{
    partial class MAN_InfoEquip
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
            this.ConTiendaEquipo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.clientes = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tipoequipo = new System.Windows.Forms.TextBox();
            this.Modelo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Serie = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Presion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Amperaje = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Tipogas = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Temperatura = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.ComboBox();
            this.NumUbica = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iddirecc = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.cargar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.tapas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pozo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tipopotencia = new System.Windows.Forms.ComboBox();
            this.potencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Observacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tienda = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConTiendaEquipo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConTiendaEquipo
            // 
            this.ConTiendaEquipo.AllowUserToAddRows = false;
            this.ConTiendaEquipo.AllowUserToDeleteRows = false;
            this.ConTiendaEquipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ConTiendaEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConTiendaEquipo.Location = new System.Drawing.Point(12, 70);
            this.ConTiendaEquipo.Name = "ConTiendaEquipo";
            this.ConTiendaEquipo.ReadOnly = true;
            this.ConTiendaEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConTiendaEquipo.Size = new System.Drawing.Size(358, 476);
            this.ConTiendaEquipo.TabIndex = 2;
            this.ConTiendaEquipo.Click += new System.EventHandler(this.ConTiendaEquipo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Cliente :";
            // 
            // clientes
            // 
            this.clientes.FormattingEnabled = true;
            this.clientes.Location = new System.Drawing.Point(55, 16);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(314, 21);
            this.clientes.TabIndex = 0;
            this.clientes.SelectionChangeCommitted += new System.EventHandler(this.clientes_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tipoequipo);
            this.groupBox1.Controls.Add(this.Modelo);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.Serie);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.Marca);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.Presion);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Amperaje);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Tipogas);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Temperatura);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Area);
            this.groupBox1.Controls.Add(this.NumUbica);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Codigo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.iddirecc);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.cargar);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cancelar);
            this.groupBox1.Controls.Add(this.actualizar);
            this.groupBox1.Controls.Add(this.tapas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pozo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tipopotencia);
            this.groupBox1.Controls.Add(this.potencia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Observacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(379, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 537);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Tipoequipo
            // 
            this.Tipoequipo.Location = new System.Drawing.Point(90, 295);
            this.Tipoequipo.Name = "Tipoequipo";
            this.Tipoequipo.Size = new System.Drawing.Size(179, 20);
            this.Tipoequipo.TabIndex = 45;
            // 
            // Modelo
            // 
            this.Modelo.Location = new System.Drawing.Point(90, 239);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(75, 20);
            this.Modelo.TabIndex = 44;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(2, 298);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "Tipo Equipo :";
            // 
            // Serie
            // 
            this.Serie.Location = new System.Drawing.Point(243, 235);
            this.Serie.Name = "Serie";
            this.Serie.Size = new System.Drawing.Size(75, 20);
            this.Serie.TabIndex = 40;
            this.Serie.TextChanged += new System.EventHandler(this.Serie_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(176, 242);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "Serie :";
            // 
            // Marca
            // 
            this.Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Marca.FormattingEnabled = true;
            this.Marca.Items.AddRange(new object[] {
            "Null",
            "R134",
            "R404",
            "R22"});
            this.Marca.Location = new System.Drawing.Point(90, 269);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(228, 21);
            this.Marca.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 277);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Marca :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Modelo :";
            // 
            // Presion
            // 
            this.Presion.Location = new System.Drawing.Point(203, 94);
            this.Presion.Name = "Presion";
            this.Presion.Size = new System.Drawing.Size(62, 20);
            this.Presion.TabIndex = 7;
            this.Presion.Text = "0";
            this.Presion.TextChanged += new System.EventHandler(this.Presion_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(157, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Presión :";
            // 
            // Amperaje
            // 
            this.Amperaje.Location = new System.Drawing.Point(325, 94);
            this.Amperaje.Name = "Amperaje";
            this.Amperaje.Size = new System.Drawing.Size(67, 20);
            this.Amperaje.TabIndex = 8;
            this.Amperaje.Text = "0";
            this.Amperaje.TextChanged += new System.EventHandler(this.Amperaje_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(271, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Amperaje :";
            // 
            // Tipogas
            // 
            this.Tipogas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipogas.FormattingEnabled = true;
            this.Tipogas.Items.AddRange(new object[] {
            "Null",
            "R134",
            "R404",
            "R22",
            "GLN",
            "GLP"});
            this.Tipogas.Location = new System.Drawing.Point(90, 121);
            this.Tipogas.Name = "Tipogas";
            this.Tipogas.Size = new System.Drawing.Size(75, 21);
            this.Tipogas.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Tipo Gas :";
            // 
            // Temperatura
            // 
            this.Temperatura.Location = new System.Drawing.Point(90, 96);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(64, 20);
            this.Temperatura.TabIndex = 6;
            this.Temperatura.Text = "0";
            this.Temperatura.TextChanged += new System.EventHandler(this.Temperatura_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Temperatura :";
            // 
            // Area
            // 
            this.Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Area.FormattingEnabled = true;
            this.Area.Items.AddRange(new object[] {
            "KW",
            "HP"});
            this.Area.Location = new System.Drawing.Point(90, 40);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(191, 21);
            this.Area.TabIndex = 4;
            // 
            // NumUbica
            // 
            this.NumUbica.Location = new System.Drawing.Point(90, 68);
            this.NumUbica.Name = "NumUbica";
            this.NumUbica.Size = new System.Drawing.Size(64, 20);
            this.NumUbica.TabIndex = 5;
            this.NumUbica.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "N. Ubicación :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Area :";
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(90, 14);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(75, 20);
            this.Codigo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Codigo :";
            // 
            // iddirecc
            // 
            this.iddirecc.AutoSize = true;
            this.iddirecc.Location = new System.Drawing.Point(173, 21);
            this.iddirecc.Name = "iddirecc";
            this.iddirecc.Size = new System.Drawing.Size(0, 13);
            this.iddirecc.TabIndex = 21;
            this.iddirecc.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(90, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Foto2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(9, 411);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(75, 23);
            this.cargar.TabIndex = 19;
            this.cargar.Text = "Foto1";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Visible = false;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(151, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "eliminar imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(347, 439);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 27);
            this.cancelar.TabIndex = 17;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(260, 439);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(75, 27);
            this.actualizar.TabIndex = 16;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // tapas
            // 
            this.tapas.Location = new System.Drawing.Point(243, 206);
            this.tapas.Name = "tapas";
            this.tapas.Size = new System.Drawing.Size(75, 20);
            this.tapas.TabIndex = 14;
            this.tapas.Text = "0";
            this.tapas.TextChanged += new System.EventHandler(this.tapas_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tapas :";
            // 
            // pozo
            // 
            this.pozo.Location = new System.Drawing.Point(90, 206);
            this.pozo.Name = "pozo";
            this.pozo.Size = new System.Drawing.Size(75, 20);
            this.pozo.TabIndex = 13;
            this.pozo.Text = "0";
            this.pozo.TextChanged += new System.EventHandler(this.pozo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Pozo :";
            // 
            // tipopotencia
            // 
            this.tipopotencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipopotencia.FormattingEnabled = true;
            this.tipopotencia.Items.AddRange(new object[] {
            "KW",
            "HP"});
            this.tipopotencia.Location = new System.Drawing.Point(171, 179);
            this.tipopotencia.Name = "tipopotencia";
            this.tipopotencia.Size = new System.Drawing.Size(57, 21);
            this.tipopotencia.TabIndex = 12;
            // 
            // potencia
            // 
            this.potencia.Location = new System.Drawing.Point(90, 180);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(75, 20);
            this.potencia.TabIndex = 11;
            this.potencia.Text = "0";
            this.potencia.TextChanged += new System.EventHandler(this.potencia_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Potencia :";
            // 
            // Observacion
            // 
            this.Observacion.Location = new System.Drawing.Point(90, 321);
            this.Observacion.Multiline = true;
            this.Observacion.Name = "Observacion";
            this.Observacion.Size = new System.Drawing.Size(332, 83);
            this.Observacion.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Observación :";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(90, 154);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(75, 20);
            this.cantidad.TabIndex = 10;
            this.cantidad.Text = "0";
            this.cantidad.TextChanged += new System.EventHandler(this.cantidad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad :";
            // 
            // Tienda
            // 
            this.Tienda.FormattingEnabled = true;
            this.Tienda.Location = new System.Drawing.Point(55, 43);
            this.Tienda.Name = "Tienda";
            this.Tienda.Size = new System.Drawing.Size(314, 21);
            this.Tienda.TabIndex = 1;
            this.Tienda.SelectionChangeCommitted += new System.EventHandler(this.Tienda_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Tienda :";
            // 
            // MAN_InfoEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 558);
            this.Controls.Add(this.Tienda);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConTiendaEquipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientes);
            this.Name = "MAN_InfoEquip";
            this.Text = "Información Equipos en Tienda";
            this.Load += new System.EventHandler(this.MAN_InfoEquip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConTiendaEquipo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConTiendaEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox clientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Observacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tipopotencia;
        private System.Windows.Forms.TextBox potencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tapas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pozo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Label iddirecc;
        private System.Windows.Forms.ComboBox Tienda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NumUbica;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Tipogas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Temperatura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Area;
        private System.Windows.Forms.TextBox Amperaje;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Presion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Serie;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox Marca;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Modelo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Tipoequipo;
    }
}