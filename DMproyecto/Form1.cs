namespace DMproyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double lado))
            {
                if (lado >= 0)
                {
                    double area = lado * lado;
                    textBox2.Text = $"�rea del cuadrado: {area} unidades�";
                }
                else
                {
                    MessageBox.Show("El lado no puede ser negativo.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un n�mero v�lido.");
            }
        }
    }
}
