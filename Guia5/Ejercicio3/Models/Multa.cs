using System.Text.RegularExpressions;

namespace Ejercicio3.Models
{
    public class Multa : IImportante
    {
        public double Importe { get; set; }


        public Multa() { }

        public Multa(double importe) { Importe = importe; }

        public bool Importar(string xml)
        {
            Regex regex = new Regex(@"<importe>([,\d]+?)<importe>", RegexOptions.IgnoreCase);
            Match match = regex.Match(xml);
            if (match.Success==true &&match.Groups.Count != 2)
            {
                return false;
            }

            Importe = Convert.ToDouble(match.Groups[1].Value);
            return true;
        }
    }
}
