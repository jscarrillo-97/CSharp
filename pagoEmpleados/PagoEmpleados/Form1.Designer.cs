namespace PagoEmpleados
{
    partial class Form1
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
            this.lblTituloEmp = new System.Windows.Forms.Label();
            this.lblNombreEmp = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblCostoHoras = new System.Windows.Forms.Label();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtCostoHoras = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbCuadroDatos = new System.Windows.Forms.GroupBox();
            this.lblMontoNeto = new System.Windows.Forms.Label();
            this.lblMontoDescuento = new System.Windows.Forms.Label();
            this.lblMontoBruto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCuadroDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloEmp
            // 
            this.lblTituloEmp.AutoSize = true;
            this.lblTituloEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEmp.Location = new System.Drawing.Point(142, 66);
            this.lblTituloEmp.Name = "lblTituloEmp";
            this.lblTituloEmp.Size = new System.Drawing.Size(299, 24);
            this.lblTituloEmp.TabIndex = 0;
            this.lblTituloEmp.Text = "Control de pago de empleados";
            this.lblTituloEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreEmp
            // 
            this.lblNombreEmp.AutoSize = true;
            this.lblNombreEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmp.Location = new System.Drawing.Point(71, 111);
            this.lblNombreEmp.Name = "lblNombreEmp";
            this.lblNombreEmp.Size = new System.Drawing.Size(86, 16);
            this.lblNombreEmp.TabIndex = 1;
            this.lblNombreEmp.Text = "Empleado: ";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(100, 152);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(57, 16);
            this.lblHoras.TabIndex = 2;
            this.lblHoras.Text = "Horas: ";
            // 
            // lblCostoHoras
            // 
            this.lblCostoHoras.AutoSize = true;
            this.lblCostoHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoHoras.Location = new System.Drawing.Point(316, 153);
            this.lblCostoHoras.Name = "lblCostoHoras";
            this.lblCostoHoras.Size = new System.Drawing.Size(101, 16);
            this.lblCostoHoras.TabIndex = 3;
            this.lblCostoHoras.Text = "Costo Horas: ";
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.Location = new System.Drawing.Point(159, 107);
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new System.Drawing.Size(399, 20);
            this.txtNombreEmp.TabIndex = 4;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(158, 149);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(135, 20);
            this.txtHoras.TabIndex = 5;
            // 
            // txtCostoHoras
            // 
            this.txtCostoHoras.Location = new System.Drawing.Point(411, 151);
            this.txtCostoHoras.Name = "txtCostoHoras";
            this.txtCostoHoras.Size = new System.Drawing.Size(147, 20);
            this.txtCostoHoras.TabIndex = 6;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(72, 234);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(108, 37);
            this.btnProcesar.TabIndex = 7;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(274, 234);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 37);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(476, 234);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 37);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gbCuadroDatos
            // 
            this.gbCuadroDatos.Controls.Add(this.lblMontoNeto);
            this.gbCuadroDatos.Controls.Add(this.lblMontoDescuento);
            this.gbCuadroDatos.Controls.Add(this.lblMontoBruto);
            this.gbCuadroDatos.Controls.Add(this.label4);
            this.gbCuadroDatos.Controls.Add(this.label3);
            this.gbCuadroDatos.Controls.Add(this.label2);
            this.gbCuadroDatos.Location = new System.Drawing.Point(72, 304);
            this.gbCuadroDatos.Name = "gbCuadroDatos";
            this.gbCuadroDatos.Size = new System.Drawing.Size(512, 125);
            this.gbCuadroDatos.TabIndex = 10;
            this.gbCuadroDatos.TabStop = false;
            this.gbCuadroDatos.Text = "Cuadro de Resumen";
            // 
            // lblMontoNeto
            // 
            this.lblMontoNeto.AutoSize = true;
            this.lblMontoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoNeto.Location = new System.Drawing.Point(384, 92);
            this.lblMontoNeto.Name = "lblMontoNeto";
            this.lblMontoNeto.Size = new System.Drawing.Size(19, 20);
            this.lblMontoNeto.TabIndex = 5;
            this.lblMontoNeto.Text = "?";
            this.lblMontoNeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMontoDescuento
            // 
            this.lblMontoDescuento.AutoSize = true;
            this.lblMontoDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoDescuento.Location = new System.Drawing.Point(183, 92);
            this.lblMontoDescuento.Name = "lblMontoDescuento";
            this.lblMontoDescuento.Size = new System.Drawing.Size(19, 20);
            this.lblMontoDescuento.TabIndex = 4;
            this.lblMontoDescuento.Text = "?";
            this.lblMontoDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMontoBruto
            // 
            this.lblMontoBruto.AutoSize = true;
            this.lblMontoBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoBruto.Location = new System.Drawing.Point(28, 92);
            this.lblMontoBruto.Name = "lblMontoBruto";
            this.lblMontoBruto.Size = new System.Drawing.Size(19, 20);
            this.lblMontoBruto.TabIndex = 3;
            this.lblMontoBruto.Text = "?";
            this.lblMontoBruto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Monto Neto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Monto Descuento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monto Bruto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.gbCuadroDatos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtCostoHoras);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtNombreEmp);
            this.Controls.Add(this.lblCostoHoras);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblNombreEmp);
            this.Controls.Add(this.lblTituloEmp);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de pago de empleados";
            this.gbCuadroDatos.ResumeLayout(false);
            this.gbCuadroDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloEmp;
        private System.Windows.Forms.Label lblNombreEmp;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblCostoHoras;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtCostoHoras;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gbCuadroDatos;
        private System.Windows.Forms.Label lblMontoNeto;
        private System.Windows.Forms.Label lblMontoDescuento;
        private System.Windows.Forms.Label lblMontoBruto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

