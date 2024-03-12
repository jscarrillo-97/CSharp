namespace sebasP4
{
    partial class frmPago
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lblFecha = new Label();
            label4 = new Label();
            label5 = new Label();
            cboCategoria = new ComboBox();
            txtEmpleado = new TextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            btnSalir = new Button();
            lvPagos = new ListView();
            columnHeader2 = new ColumnHeader("(ninguna)");
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            label3 = new Label();
            lblSueldo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 30);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 0;
            label1.Text = "CONTROL DE PAGO EMPLEADOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 85);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 1;
            label2.Text = "FECHA DE REGISTRO";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BorderStyle = BorderStyle.FixedSingle;
            lblFecha.Location = new Point(283, 85);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(2, 17);
            lblFecha.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 129);
            label4.Name = "label4";
            label4.Size = new Size(143, 15);
            label4.TabIndex = 3;
            label4.Text = "NOMBRE DEL EMPLEADO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 167);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 4;
            label5.Text = "CATEGORIA";
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Items.AddRange(new object[] { "Jefe", "Administrativo", "Tecnico", "Operario" });
            cboCategoria.Location = new Point(225, 164);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(121, 23);
            cboCategoria.TabIndex = 5;
            cboCategoria.SelectedIndexChanged += cboCategoria_SelectedIndexChanged;
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(299, 126);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(324, 23);
            txtEmpleado.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(156, 207);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(283, 207);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(156, 381);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lvPagos
            // 
            lvPagos.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader1 });
            lvPagos.GridLines = true;
            lvPagos.Location = new Point(156, 250);
            lvPagos.Name = "lvPagos";
            lvPagos.Size = new Size(467, 125);
            lvPagos.TabIndex = 10;
            lvPagos.UseCompatibleStateImageBehavior = false;
            lvPagos.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "EMPLEADO";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "CATEGORIA";
            columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "SUELDO";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "DESCUENTO";
            columnHeader5.Width = 80;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "NETO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(398, 167);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 11;
            label3.Text = "SUELDO";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.BorderStyle = BorderStyle.FixedSingle;
            lblSueldo.Location = new Point(470, 164);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(12, 17);
            lblSueldo.TabIndex = 12;
            lblSueldo.Text = " ";
            // 
            // frmPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSueldo);
            Controls.Add(label3);
            Controls.Add(lvPagos);
            Controls.Add(btnSalir);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtEmpleado);
            Controls.Add(cboCategoria);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblFecha);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPago";
            Text = "frmPago";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblFecha;
        private Label label4;
        private Label label5;
        private ComboBox cboCategoria;
        private TextBox txtEmpleado;
        private Button btnRegistrar;
        private Button btnCancelar;
        private Button btnSalir;
        private ListView lvPagos;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader1;
        public ColumnHeader columnHeader2;
        private Label label3;
        private Label lblSueldo;
    }
}