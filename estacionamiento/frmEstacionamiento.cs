using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estacionamiento
{
    public partial class frmEstacionamiento : Form
    {
        string dia;
        public frmEstacionamiento()
        {
            InitializeComponent();
        }

        private void frmEstacionamiento_Load(object sender, EventArgs e)
        {
            //Mostra fecha actual
            lblFecha.Text = DateTime.Now.ToShortDateString();

            //determinar el dia
            DateTime fecha = DateTime.Parse(lblFecha.Text);
            dia =  fecha.ToString("dddd");

            double costo = 0;
            switch (dia)
            {

                case "Domingo": costo = 2; break;
                case "Lunes":
                case "Martes":
                case "Miercoles":
                case "Jueves":
                    costo = 4; break;
                case "Viernes":
                case "Sabado":
                costo = 7; break;
            }
            lblCosto.Text = costo.ToString("0.00");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //capturar datos del formulario
            string placa = txtPlaca.Text;
            double costo = double.Parse(lblCosto.Text);
            DateTime fecha = DateTime.Parse(lblFecha.Text);
            DateTime horaInicio = DateTime.Parse(txtHoraInicio.Text);
            DateTime horaFin   = DateTime.Parse(txtHoraFin.Text);

            //Calcular la hora
            TimeSpan hora = horaFin - horaInicio;

            //Calcular el importe
            double importe = costo * (hora.TotalHours);

            ListViewItem fila = new ListViewItem(placa);
            fila.SubItems.Add(fecha.ToString("d"));
            fila.SubItems.Add(horaInicio.ToString("t"));
            fila.SubItems.Add(horaFin.ToString("t"));
            fila.SubItems.Add(hora.TotalHours.ToString(""));
            fila.SubItems.Add(costo.ToString("C"));
            fila.SubItems.Add(importe.ToString("C"));
            lvRegistro.Items.Add(fila);
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPlaca.Clear();
            txtHoraInicio.Clear();
            txtHoraFin.Clear();
            txtPlaca.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta Seguro de salir",
                                               "Estacionamiento",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes) this.Close();
        }
    }
}
