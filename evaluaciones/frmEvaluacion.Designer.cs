namespace j.j_taller4
{
    partial class frmEvaluacion
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.Evaluaciones = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtE1 = new System.Windows.Forms.TextBox();
            this.txtE2 = new System.Windows.Forms.TextBox();
            this.txtE3 = new System.Windows.Forms.TextBox();
            this.txtE4 = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lvRegistro = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE REGISTRO DE EVALUACIONES\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ALUMNO\r\n";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(37, 140);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(190, 20);
            this.txtAlumno.TabIndex = 3;
            this.txtAlumno.Validated += new System.EventHandler(this.txtAlumno_Validated);
            // 
            // Evaluaciones
            // 
            this.Evaluaciones.FormattingEnabled = true;
            this.Evaluaciones.Location = new System.Drawing.Point(259, 108);
            this.Evaluaciones.Name = "Evaluaciones";
            this.Evaluaciones.Size = new System.Drawing.Size(264, 108);
            this.Evaluaciones.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Eval.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Eval.2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Eval.3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Eval.4";
            // 
            // txtE1
            // 
            this.txtE1.Location = new System.Drawing.Point(285, 164);
            this.txtE1.Name = "txtE1";
            this.txtE1.Size = new System.Drawing.Size(39, 20);
            this.txtE1.TabIndex = 9;
            this.txtE1.Validated += new System.EventHandler(this.txtE1_Validated);
            // 
            // txtE2
            // 
            this.txtE2.Location = new System.Drawing.Point(342, 164);
            this.txtE2.Name = "txtE2";
            this.txtE2.Size = new System.Drawing.Size(37, 20);
            this.txtE2.TabIndex = 10;
            this.txtE2.Validated += new System.EventHandler(this.txtE2_Validated);
            // 
            // txtE3
            // 
            this.txtE3.Location = new System.Drawing.Point(400, 163);
            this.txtE3.Name = "txtE3";
            this.txtE3.Size = new System.Drawing.Size(41, 20);
            this.txtE3.TabIndex = 11;
            this.txtE3.Validated += new System.EventHandler(this.txtE3_Validated);
            // 
            // txtE4
            // 
            this.txtE4.Location = new System.Drawing.Point(457, 163);
            this.txtE4.Name = "txtE4";
            this.txtE4.Size = new System.Drawing.Size(42, 20);
            this.txtE4.TabIndex = 12;
            this.txtE4.Validated += new System.EventHandler(this.txtE4_Validated);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(224, 405);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(58, 405);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(82, 23);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(448, 405);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.columnHeader7,
            this.columnHeader8});
            this.lvRegistro.GridLines = true;
            this.lvRegistro.HideSelection = false;
            this.lvRegistro.Location = new System.Drawing.Point(37, 246);
            this.lvRegistro.Name = "lvRegistro";
            this.lvRegistro.Size = new System.Drawing.Size(493, 131);
            this.lvRegistro.TabIndex = 17;
            this.lvRegistro.UseCompatibleStateImageBehavior = false;
            this.lvRegistro.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ALUMNO";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "E1";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "E2";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E3";
            this.columnHeader4.Width = 40;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "E4";
            this.columnHeader5.Width = 40;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MENOR";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "PROMEDIO";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "CONDICION";
            this.columnHeader8.Width = 80;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.lvRegistro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtE4);
            this.Controls.Add(this.txtE3);
            this.Controls.Add(this.txtE2);
            this.Controls.Add(this.txtE1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Evaluaciones);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.ListBox Evaluaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtE1;
        private System.Windows.Forms.TextBox txtE2;
        private System.Windows.Forms.TextBox txtE3;
        private System.Windows.Forms.TextBox txtE4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListView lvRegistro;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ErrorProvider epError;
    }
}

