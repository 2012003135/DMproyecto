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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double D) &&
                double.TryParse(textBox2.Text, out double d))
            {
                if (D > 0 && d > 0)
                {
                    double area = (D * d) / 2;
                    textBox3.Text = $"Área del rombo: {area:F2} unidades²";
                }
                else
                {
                    MessageBox.Show("Ambas diagonales deben ser mayores que cero.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Ingresa valores numéricos válidos.", "Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
