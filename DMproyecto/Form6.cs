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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double baseParalelogramo) &&
                double.TryParse(textBox2.Text, out double altura))
            {
                if (baseParalelogramo > 0 && altura > 0)
                {
                    double area = baseParalelogramo * altura;
                    textBox3.Text = $"Área del paralelogramo: {area:F2} unidades²";
                }
                else
                {
                    MessageBox.Show("La base y la altura deben ser mayores que cero.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.", "Error");
            }
        }
    }
}
