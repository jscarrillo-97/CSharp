namespace sebasP4
{
    public partial class frmPago : Form
    {
        double sueldo = 0;
        public frmPago()
        {
            InitializeComponent();
        }


        private void frmPago_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("C");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //CAPTURANDO LOS VALORES
            string empleado = txtEmpleado.Text;
            string categoria = cboCategoria.Text;

            //realizando calculos
            double descuento = 0;
            if (sueldo > 2000) descuento =
                sueldo * (12.5 / 100);

            double neto = sueldo - descuento;

            //IMPRIMIENDO LOS RESULTADOS EN LA LISTA
            ListViewItem fila = new ListViewItem(empleado);
            fila.SubItems.Add(categoria);
            fila.SubItems.Add(sueldo.ToString("C"));
            fila.SubItems.Add(descuento.ToString("C"));
            fila.SubItems.Add(neto.ToString("C"));
            lvPagos.Items.Add(fila);

            //LIMPIANDO LOS CONTROLES
            // btnCancelar_Click(sender, e);

        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CAPTURANDO LA CATEGORIA SELECCIONADA
            string categoria = cboCategoria.Text;

            //Asignando el sueldo segun la categoria
            if (categoria == "Jefe") sueldo = 3500;
            if (categoria == "Administrativo") sueldo = 2500;
            if (categoria == "Tecnico") sueldo = 1700;
            if (categoria == "Operario") sueldo = 1000;

            //ENVIANDO EL SUELDO OBTENIDO A LA IMPRESION
            lblSueldo.Text = sueldo.ToString("C");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cboCategoria.Text = "(Seleccione)";
            txtEmpleado.Clear();
            txtEmpleado.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?",
                                             "Pago",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes) this.Close();
        }

         
    }
}