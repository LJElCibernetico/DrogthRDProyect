using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DroughtRDProyect.UI
{
    public partial class rAnimalDrougth : Form
    {
        public rAnimalDrougth()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /* (1,54 x los kilos de materia seca consumida) 
              + (1,33 x el peso vivo de la vaca) 
              +(0,89 x el porcentaje de materia seca de la ración) 
              + (0,58 x la temperatura mínima ambiental) 
              – (0,30 x los milímetros de lluvia medios anuales en la zona) 
              – 25,65 = litros de agua consumida al día.
            */
            Double.TryParse(MateriaSecaTextBox.Text, out double materiaSeca);
            Double.TryParse(PesoVivoTextBox.Text, out double pesoVivo);
            Double.TryParse(TempMinAmbTextBox.Text, out double TempMin);
            Double.TryParse(LluviaTextBox.Text, out double lluvia);
            double resultado = (1.54 * materiaSeca) + (1.33 * pesoVivo)
                             + (0.58 * TempMin) + (0.30 * lluvia) - 25.65;
            ResultadoTextBox.Text = (resultado + "\n Litros de agua consumida al dia");
            ResultadoTextBox.TextAlign = HorizontalAlignment.Center;
        }
    }
}
