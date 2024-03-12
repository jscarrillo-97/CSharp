namespace sebas3
{
    public partial class frmRollo : Form
    {
        public frmRollo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //CAPTURANDO LOS VALORES
            double altura = double.Parse(txtAltura.Text);
            double diametro = double.Parse(txtDiametro.Text);

            //REALIZANDO LOS CALCULOS
            double radio = diametro / 2;
            double area = (2 * Math.PI * radio) * (radio + altura);
            double volumen = Math.PI * Math.Pow(radio, 2) * altura;

            //MOSTRANDO LOS RESULTADOS EN EL CUADRO DE TEXTO
            txtR.Text = "** RESUMEN DE VOLUMEN Y AREAS **";
            txtR.Text += "\r\nVALOR ALTURA :" + altura.ToString("0.00");
            txtR.Text += "\r\nVALOR DIAMETRO :" + diametro.ToString("0.00");
            txtR.Text += "\r\n-------------------";
            txtR.Text += "\r\nRADIO :" + altura.ToString("0.00");
            txtR.Text += "\r\nAREA :" + area.ToString("0.00");
            txtR.Text += "\r\nVOLUMEN :" + volumen.ToString("0.00");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtDiametro.Clear();
            txtR.Clear();
            txtAltura.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ESTA SEGURO DE SALIR?", "MEDIDA",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Information);

            if (r == DialogResult.Yes) this.Close();

        }
    }
}
