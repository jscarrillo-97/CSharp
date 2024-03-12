namespace registroParticipantes
{
    partial class frmParticipantes
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lvParticipantes = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtParticipante = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lvEstadisticas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.tHora = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FECHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "HORA";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumero.Location = new System.Drawing.Point(162, 20);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(15, 15);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "?";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFecha.Location = new System.Drawing.Point(162, 52);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(15, 15);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "?";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHora.Location = new System.Drawing.Point(162, 87);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(15, 15);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "FORMULARIO DE REGISTRO DE PARTICIPANTES";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "NOMBRE COMPLETO DEL PARTICIPANTE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "CARGO";
            // 
            // lvParticipantes
            // 
            this.lvParticipantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvParticipantes.GridLines = true;
            this.lvParticipantes.HideSelection = false;
            this.lvParticipantes.Location = new System.Drawing.Point(77, 196);
            this.lvParticipantes.Name = "lvParticipantes";
            this.lvParticipantes.Size = new System.Drawing.Size(467, 149);
            this.lvParticipantes.TabIndex = 9;
            this.lvParticipantes.UseCompatibleStateImageBehavior = false;
            this.lvParticipantes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "NUMERO";
            this.columnHeader3.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PARTICIPANTE";
            this.columnHeader4.Width = 105;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CARGO";
            this.columnHeader5.Width = 128;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "FECHA";
            this.columnHeader6.Width = 78;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "HORA";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(566, 491);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtParticipante
            // 
            this.txtParticipante.Location = new System.Drawing.Point(77, 147);
            this.txtParticipante.Name = "txtParticipante";
            this.txtParticipante.Size = new System.Drawing.Size(250, 20);
            this.txtParticipante.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(566, 142);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 23);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lvEstadisticas
            // 
            this.lvEstadisticas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvEstadisticas.GridLines = true;
            this.lvEstadisticas.HideSelection = false;
            this.lvEstadisticas.Location = new System.Drawing.Point(77, 351);
            this.lvEstadisticas.Name = "lvEstadisticas";
            this.lvEstadisticas.Size = new System.Drawing.Size(360, 163);
            this.lvEstadisticas.TabIndex = 13;
            this.lvEstadisticas.UseCompatibleStateImageBehavior = false;
            this.lvEstadisticas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CARGOS";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TOTALIZADOR";
            this.columnHeader2.Width = 187;
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Jefe",
            "Operario",
            "Administrativo",
            "Practicante"});
            this.cboCargo.Location = new System.Drawing.Point(372, 144);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(172, 21);
            this.cboCargo.TabIndex = 14;
            // 
            // tHora
            // 
            this.tHora.Tick += new System.EventHandler(this.tHora_Tick);
            // 
            // frmParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.lvEstadisticas);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtParticipante);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvParticipantes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmParticipantes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmParticipantes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvParticipantes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtParticipante;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListView lvEstadisticas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.Timer tHora;
    }
}

