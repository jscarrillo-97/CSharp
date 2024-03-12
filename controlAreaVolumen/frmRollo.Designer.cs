namespace sebas3
{
    partial class frmRollo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRollo));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAltura = new TextBox();
            txtDiametro = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtR = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(160, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(465, 96);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(405, 148);
            label1.Name = "label1";
            label1.Size = new Size(179, 15);
            label1.TabIndex = 1;
            label1.Text = "CONTROL DE AREA Y VOLUMEN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 202);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "ALTURA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 202);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 3;
            label3.Text = "DIAMETRO";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(146, 230);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 4;
            // 
            // txtDiametro
            // 
            txtDiametro.Location = new Point(292, 230);
            txtDiametro.Name = "txtDiametro";
            txtDiametro.Size = new Size(100, 23);
            txtDiametro.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(292, 277);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(505, 363);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 23);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(620, 363);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtR
            // 
            txtR.Location = new Point(429, 204);
            txtR.Multiline = true;
            txtR.Name = "txtR";
            txtR.Size = new Size(291, 153);
            txtR.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtR);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtDiametro);
            Controls.Add(txtAltura);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAltura;
        private TextBox txtDiametro;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtR;
    }
}