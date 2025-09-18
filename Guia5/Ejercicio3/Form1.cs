using System.Text.RegularExpressions;
using Ejercicio3.Models;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            List<Vehiculos> vehiculos = new List<Vehiculos> ();
            Regex regex = new Regex(@"<multa> [\s\s]*?<multa>", RegexOptions.IgnoreCase);
            Match match = regex.Match(textBox1.Text);
            while (match.Success)
            {
                string objectXML = match.Value;

                Vehiculos nuevo = new Vehiculos();

                if (nuevo.Importar(objectXML))
                {
                    vehiculos.Sort();
                    int idx = vehiculos.BinarySearch(nuevo);
                    if (idx > -1)
                    {
                        for (int i = 0; i < nuevo.CantidadMultas; i++)
                        {
                            vehiculos[idx].AgregarMulta(nuevo.VerMulta(i));
                        }
                    }
                    else
                    {
                        vehiculos.Add(nuevo);
                    }
                }
                match = match.NextMatch(); //solicita la siguente coincidecia
            }
        }
    }
}
