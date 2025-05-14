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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n) &&
                double.TryParse(textBox2.Text, out double L) &&
                double.TryParse(textBox3.Text, out double a))
            {
                if (n >= 3 && L > 0 && a > 0)
                {
                    double area = (n * L * a) / 2;
                    textBox4.Text = $"Área del polígono regular: {area:F2} unidades²";
                }
                else
                {
                    MessageBox.Show("El número de lados debe ser ≥ 3 y los valores deben ser positivos.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Ingresa valores numéricos válidos.", "Error");
            }
        }
    }
}
