using System.Text;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Random azaa = new Random();
        List <string> apellidos = new List<string> { "Hernandez", "Saavedra", "Acosta", "Jacob", "Heinze", "Fischer", "Campos" };
        List<string> nombres = new List<string> {"Adriana", "Elizabet", "José", "María", "Ernesto", "Sebastian", "Julio" ,
                "Ester", "Ariel", "Betiana", "Silvina", "Ana", "Leandro", "Ayelen", "Daniela", "Miguel" };
        private void btnGenerarListado_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10000; i++)
            {
                int a = azaa.Next(0, apellidos.Count);
                int n = azaa.Next(0, nombres.Count);

                sb.AppendLine($"{apellidos[a]} {nombres[n]}");
            }
            //otra forma con un textbox
            //textbox1.Text = sb.ToString();

            lbNombres.Items.AddRange(sb.ToString().Split("\n"));
        }
    }
}
