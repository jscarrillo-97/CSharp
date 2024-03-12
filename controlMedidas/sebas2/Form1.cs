using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sebas2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //CAPTURANDO EL VALOR EN METROS
            double metros = double.Parse(txtMetros.Text);


            //REALIZANDO CONVERSIONES
            double centimetros = metros * 100;
            double pulgadas = centimetros / 2.54;
            double pies = pulgadas / 12;
            double yardas = pies / 3;

            //MOSTRANDO LOS RESULTADOS DE LA CONVERSION
            lstR.Items.Add("** RESUMEN DE CONVERSIONES**");
            lstR.Items.Add("MEDIDA EN METROS :" + metros.ToString("0.00"));
            lstR.Items.Add("-------------------------");
            lstR.Items.Add("MEDIDA EN CENTIMETROS :" + centimetros.ToString("0.00"));
            lstR.Items.Add("MEDIDA EN PULGADAS :" + pulgadas.ToString("0.00"));
            lstR.Items.Add("MEDIDA EN PIES :" + pies.ToString("0.00"));
            lstR.Items.Add("MEDIDA EN YARDAS :" + yardas.ToString("0.00"));



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMetros.Clear();
            lstR.Items.Clear();
            txtMetros.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("ESTA SEGURO DE SALIR ?", "MEDIDAS",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Information);
            if (R == DialogResult.Yes) this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
