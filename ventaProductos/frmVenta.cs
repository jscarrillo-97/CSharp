using System.Windows.Forms;
using System;
using Microsoft.VisualBasic;

namespace sebas6
{
    public partial class frmVenta : Form
    {
        double precio = 0;


        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.ToString("d");
            lblPrecio.Text = (0).ToString("C");
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = cboProducto.Text;

            if (producto.Equals("Colección Escolar"))
                precio = 250;
            else if (producto.Equals("Colección PreUniversitaria"))
                precio = 150;
            else if (producto.Equals("Colección Profesional"))
                precio = 350;

            lblPrecio.Text = precio.ToString("C");

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validando
            if (cboProducto.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un producto..!!!");  
             else if (!Information.IsNumeric(txtCantidad.Text))
                MessageBox.Show("Debe ingresar una cantidad numérica..!!!");
            else if (cboTipo.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un tipo..!!!");
            else
            {
                // Capturando datos
                string producto = cboProducto.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                string tipo = cboTipo.Text;

                // Procesar cálculos
                double subtotal = cantidad * precio;

                double descuento = 0, recargo = 0;
                if (tipo.Equals("Contado"))
                    descuento = 0.05 * subtotal;
                else
                    recargo = 0.1 * subtotal;

                double preciofinal = subtotal - descuento + recargo;

                // Impresión de resultados
                ListViewItem fila = new ListViewItem(producto);
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString("C"));
                fila.SubItems.Add(tipo);
                fila.SubItems.Add(descuento.ToString("C"));
                fila.SubItems.Add(recargo.ToString("C"));
                fila.SubItems.Add(preciofinal.ToString("C"));

                lvVenta.Items.Add(fila);
                btnCancelar_Click(sender, e);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
             
            cboProducto.Text = "(Seleccione producto)";// Limpiar los elementos del ComboBox
            cboTipo.Text = "(Seleccione tipo)";
            txtCantidad.Clear();
            lblPrecio.Text = (0).ToString("C");
            cboProducto.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Está seguro de salir?", "Venta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void frmVenta_Load_1(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
            lblPrecio.Text = precio.ToString("C");

        }
    }
}