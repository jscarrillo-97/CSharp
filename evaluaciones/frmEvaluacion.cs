using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace j.j_taller4
{
    public partial class frmEvaluacion : Form
    {
        public frmEvaluacion()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string alumno = txtAlumno.Text;
            int e1 = int.Parse(txtE1.Text);
            int e2 = int.Parse(txtE2.Text);
            int e3 = int.Parse(txtE3.Text);
            int e4 = int.Parse(txtE4.Text);

            int menor;
            if (e1 < e2) menor = e1; else menor = e2;
            if (e3 <menor) menor = e3;
            if (e4 <menor) menor = e4;

            double promedio = (e1 + e2 + e3 + e4 - menor ) / 3;

            //Determinando la condicion
            string condicion;
            if (promedio <= 12.49)
                condicion = "DESAPROBADO";
            else
                condicion = "APROBADO";

            //Imprimiendo los resultados
            ListViewItem fila = new ListViewItem(alumno);
            fila.SubItems.Add(e1.ToString());
            fila.SubItems.Add(e2.ToString());
            fila.SubItems.Add(e3.ToString());
            fila.SubItems.Add(e4.ToString());
            fila.SubItems.Add(menor.ToString());
            fila.SubItems.Add(promedio.ToString());
            fila.SubItems.Add(condicion.ToString());
            lvRegistro.Items.Add(fila);

            //Limpiando los controles
            btnCancelar_Click(sender,e);

        }

        private void txtAlumno_Validated(object sender, EventArgs e)
        {
            if (txtAlumno.Text.Trim() == ""){
                epError.SetError(txtAlumno,"ingrese el nombre del alumno...");
                txtAlumno.Focus();

        } else {
                epError.Clear();
            }
        }

        private void txtE1_Validated(object sender, EventArgs e)
        {
            if (txtE1.Text.Trim() == "")
            {
                epError.SetError(txtE1, "ingrese el nombre del alumno...");
                txtE1.Focus();

            }
            else
            {
                epError.Clear();
            }
        
    }

        private void txtE2_Validated(object sender, EventArgs e)
        {
            if (txtE2.Text.Trim() == "")
            {
                epError.SetError(txtE2, "ingrese el nombre del alumno...");
                txtE2.Focus();

            }
            else
            {
                epError.Clear();
            }
        }

        private void txtE3_Validated(object sender, EventArgs e)
        {
            if (txtE3.Text.Trim() == "")
            {
                epError.SetError(txtE3, "ingrese el nombre del alumno...");
                txtE3.Focus();

            }
            else
            {
                epError.Clear();
            }
        }

        private void txtE4_Validated(object sender, EventArgs e)
        {
            if (txtE4.Text.Trim() == "")
            {
                epError.SetError(txtE4, "ingrese el nombre del alumno...");
                txtE4.Focus();

            }
            else
            {
                epError.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtAlumno.Clear();
            txtE1.Clear();
            txtE2.Clear();
            txtE3.Clear();
            txtE4.Clear();
            txtAlumno.Focus();    

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Está seguro de salir?", "PROMEDIO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}