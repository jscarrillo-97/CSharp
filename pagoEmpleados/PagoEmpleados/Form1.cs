using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblTituloEmp.Left = (this.Width - lblTituloEmp.Width) / 2;
        }



        //.StartPosition = FormStartPosition.CenterParent;

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int horas = int.Parse(txtHoras.Text);
            double costohoras = double.Parse(txtCostoHoras.Text);

            double sueldobasico = horas * costohoras;
            double bonificacion = 20.0/100.0 * sueldobasico;
            double sueldobruto = sueldobasico + bonificacion;
            double descuento = sueldobruto * 12.0/100.0;
            double sueldoneto = sueldobruto - descuento;

            lblMontoBruto.Text = sueldobruto.ToString("C");
            lblMontoDescuento.Text = descuento.ToString("C");
            lblMontoNeto.Text = sueldoneto.ToString("C");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreEmp.Clear();
            txtHoras.Clear();
            txtCostoHoras.Clear();

            lblMontoBruto.Text = "";
            lblMontoDescuento.Text = "";
            lblMontoNeto.Text = "";
            txtNombreEmp.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Esta seguro que desea salir", "Control de Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rta==DialogResult.Yes)
            {
                this.Close();
            }
        }

        
    }
}
