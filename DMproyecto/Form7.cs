using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMproyecto
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double baseMayor) &&
                double.TryParse(textBox2.Text, out double baseMenor) &&
                double.TryParse(textBox3.Text, out double altura))
            {
                if (baseMayor > 0 && baseMenor > 0 && altura > 0)
                {
                    double area = ((baseMayor + baseMenor) * altura) / 2;
                    textBox4.Text = $"Área del trapecio: {area:F2} unidades²";
                }
                else
                {
                    MessageBox.Show("Las bases y la altura deben ser mayores que cero.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.", "Error");
            }
        }
    }
}
