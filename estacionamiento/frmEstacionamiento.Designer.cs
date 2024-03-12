namespace estacionamiento
{
    partial class frmEstacionamiento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHoraFin = new System.Windows.Forms.TextBox();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lvRegistro = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLACA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "COSTO DEL DIA $";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHoraFin);
            this.groupBox1.Controls.Add(this.txtHoraInicio);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(402, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FECHA Y HORA";
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Location = new System.Drawing.Point(140, 115);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.Size = new System.Drawing.Size(75, 20);
            this.txtHoraFin.TabIndex = 5;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(140, 81);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(75, 20);
            this.txtHoraInicio.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFecha.Location = new System.Drawing.Point(172, 48);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(2, 15);
            this.lblFecha.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "HORA SALIDA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "HORA INICIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "FECHA";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCosto.Location = new System.Drawing.Point(326, 101);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(2, 15);
            this.lblCosto.TabIndex = 3;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(110, 96);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(117, 20);
            this.txtPlaca.TabIndex = 4;
            // 
            // lvRegistro
            // 
            this.lvRegistro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvRegistro.GridLines = true;
            this.lvRegistro.HideSelection = false;
            this.lvRegistro.Location = new System.Drawing.Point(96, 257);
            this.lvRegistro.Name = "lvRegistro";
            this.lvRegistro.Size = new System.Drawing.Size(544, 121);
            this.lvRegistro.TabIndex = 5;
            this.lvRegistro.UseCompatibleStateImageBehavior = false;
            this.lvRegistro.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PLACA";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FECHA";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "HORA INICIO";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "HORA FIN";
            this.columnHeader4.Width = 69;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "HORAS";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TARIFA";
            this.columnHeader6.Width = 82;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "IMPORTE";
            this.columnHeader7.Width = 112;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(452, 401);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(308, 401);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(157, 401);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(83, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "CONTROL DE REGISTRO ESTACIONAMIENTO";
            // 
            // frmEstacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvRegistro);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEstacionamiento";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEstacionamiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ListView lvRegistro;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtHoraFin;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label6;
    }
}

