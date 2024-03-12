using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registroParticipantes
{
    public partial class frmParticipantes : Form
    {
        int num;
        int cJefe, cOperario, cAdministrativo, cPracticante;

        
        public frmParticipantes()
        {
            InitializeComponent();
            tHora.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir ?",
                                             "Participantes",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }

        private void frmParticipantes_Load(object sender, EventArgs e)
        {
            num++;
            lblFecha.Text = DateTime.Now.Date.ToString("d");
            lblNumero.Text = num.ToString("D4");
        }

        private void tHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.Date.ToString("hh:mm:ss");

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //CAPTURAR LOS DATOS
            DateTime fecha,hora;
            string participante, cargo;
            int numero;
            participante = txtParticipante.Text;
            numero = int.Parse(lblNumero.Text);
            fecha = DateTime.Parse(lblFecha.Text);
            hora = DateTime.Parse(lblHora.Text);
            cargo = cboCargo.Text;

            //CONTABILIZAR LA CANTIDAD SEGUN LOS CARGOS
            switch (cargo)
            {
                case "Jefe": cJefe++; break;
                case "Operario": cOperario++; break;
                case "Administrativo": cAdministrativo++; break;
                case "Practicante": cPracticante++; break;
            }
            //IMPRIMIENDO EL REGISTRO
            ListViewItem fila = new ListViewItem(numero.ToString());
            fila.SubItems.Add(participante);
            fila.SubItems.Add(cargo);
            fila.SubItems.Add(fecha.ToString("d"));
            fila.SubItems.Add(hora.ToString("hh:mm:ss"));
            lvParticipantes.Items.Add(fila);

            //IMPRIMIENDO LAS ESTADISTICAS
            lvEstadisticas.Items.Clear();
            string[] elementosFila = new string[2];
            ListViewItem row;

            //AÑADIMOS LA PRIMERA FILA AL lvEstadisticas
            elementosFila[0] = "Jefe";
            elementosFila[1] = cJefe.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            //AÑADIMOS LA SEGUNDA FILA AL lvEstadisticas
            elementosFila[0] = "Operario";
            elementosFila[1] = cOperario.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            //AÑADIMOS LA TERCERA FILA AL lvEstadisticas
            elementosFila[0] = "Administrativo";
            elementosFila[1] = cAdministrativo.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            //AÑADIMOS LA SEGUNDA FILA AL lvEstadisticas
            elementosFila[0] = "Practicante";
            elementosFila[1] = cPracticante.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            //MOSTRANDO EL NUEVO NUMERO DE REGISTRO
            num++;
            lblNumero.Text = num.ToString("D4");

            //LIMPIANDO LOS CONTROLES
            txtParticipante.Clear();
            cboCargo.SelectedIndex = -1;
            txtParticipante.Focus();

        }



    }
}
