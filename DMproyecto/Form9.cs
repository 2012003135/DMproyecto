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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double L))
            {
                if (L > 0)
                {
                    double area = (3 * Math.Sqrt(3) * Math.Pow(L, 2)) / 2;
                    textBox2.Text = $"Área del hexágono regular: {area:F2} unidades²";
                }
                else
                {
                    MessageBox.Show("El lado debe ser un valor positivo.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor numérico válido.", "Error");
            }
        }
    }
}
