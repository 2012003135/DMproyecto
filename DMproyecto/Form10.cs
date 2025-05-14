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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double L) &&
                double.TryParse(textBox2.Text, out double a))
            {
                if (L > 0 && a > 0)
                {
                    double area = (7 * L * a) / 2;
                    textBox3.Text = $"Área del heptágono regular: {area:F2} unidades²";
                }
                else
                {
                    MessageBox.Show("El lado y la apotema deben ser mayores que cero.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.", "Error");
            }
        }
    }
}
