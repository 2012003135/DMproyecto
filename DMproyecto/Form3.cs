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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double baseTriangulo) &&
                double.TryParse(textBox2.Text, out double altura))
            {
                if (baseTriangulo >= 0 && altura >= 0)
                {
                    double area = (baseTriangulo * altura) / 2;
                    textBox3.Text = $"Área del triángulo: {area} unidades²";
                }
                else
                {
                    MessageBox.Show("La base y la altura deben ser positivas.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.", "Error");
            }
        }
    }
}
