namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string expresion = textBox1.Text;

            int cantNumeros = 0;
            for (int i = 0; i < expresion.Length; i++)
            {
                if (char.IsDigit(expresion[i]) == true)
                {
                    cantNumeros++;
                }
            }
            if (cantNumeros > expresion.Length)
            {
                textBox2.Text = "es valido";
            }
            else
            {
                textBox2.Text = "no es valido";
            }
        }
    }
}
