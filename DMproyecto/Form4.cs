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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double radio))
            {
                if (radio >= 0)
                {
                    double area = Math.PI * Math.Pow(radio, 2);
                    textBox2.Text = $"Área del círculo: {area:F2} unidades²";
                }
                else
                {
                    MessageBox.Show("El radio debe ser un número positivo.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Ingresa un valor numérico válido para el radio.", "Error");
            }
        }
    }
}
