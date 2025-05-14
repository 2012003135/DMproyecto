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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double baseRectangulo) &&
                double.TryParse(textBox2.Text, out double altura))
            {
                if (baseRectangulo >= 0 && altura >= 0)
                {
                    double area = baseRectangulo * altura;
                    textBox3.Text = $"Área del rectángulo: {area} unidades²";
                }
                else
                {
                    MessageBox.Show("Base y altura deben ser valores positivos.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa números válidos.", "Error");
            }
        }
    }
}
