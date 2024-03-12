namespace sebas6
{
    partial class frmVenta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvVenta = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE REGISTRO DE VENTAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(66, 92);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(105, 13);
            this.s.TabIndex = 1;
            this.s.Text = "Seleccione producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seleccione tipo de pago";
            // 
            // lvVenta
            // 
            this.lvVenta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvVenta.GridLines = true;
            this.lvVenta.HideSelection = false;
            this.lvVenta.Location = new System.Drawing.Point(60, 232);
            this.lvVenta.Name = "lvVenta";
            this.lvVenta.Size = new System.Drawing.Size(537, 206);
            this.lvVenta.TabIndex = 3;
            this.lvVenta.UseCompatibleStateImageBehavior = false;
            this.lvVenta.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PRODUCTO";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CANT";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PRECIO";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TIPO PAGO";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DESCUENTO";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "RECARGO";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "PRECIO FINAL";
            this.columnHeader7.Width = 90;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "(Seleccione tipo)",
            "Contado",
            "Tarjeta"});
            this.cboTipo.Location = new System.Drawing.Point(69, 159);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 4;
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Items.AddRange(new object[] {
            "Colección escolar",
            "Colección PreUniversitaria",
            "Colección Profesional"});
            this.cboProducto.Location = new System.Drawing.Point(69, 108);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(207, 21);
            this.cboProducto.TabIndex = 5;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(69, 199);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(187, 199);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(89, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio del producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecio.Location = new System.Drawing.Point(551, 165);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(12, 15);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = " ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFecha.Location = new System.Drawing.Point(594, 90);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(12, 15);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Fecha Actual";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(312, 111);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(141, 20);
            this.txtCantidad.TabIndex = 14;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lvVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.s);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVenta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmVenta_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvVenta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}

