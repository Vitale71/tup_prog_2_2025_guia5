using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Vehiculos : IImportante, IComparable<Vehiculos>
    {
        public string patente {  get; set; }
        public int CantidadMultas { get { return multas.Count; } }
        public double ImporteTotal { get; private set; }
        List<Multa> multas = new List<Multa>();
        
        public Vehiculos() { }
        public Vehiculos(string patente )
        {
            this.patente = patente;
            
        }

        public void AgregarMulta(Multa multa) 
        {
            multas.Add(multa);
            ImporteTotal += multa.Importe;
        }
        public bool importar (string xml)
        {
            return true;
        }

        public Multa VerMulta(int id)
        {
            if (id >= 0 && id < CantidadMultas)
            {
                return multas[id];
            }

            return null;
        }
        public bool Importar(string xml)
        {
            Regex regex = new Regex(@"<patente>([\s\w]+?)<patente>", RegexOptions.IgnoreCase);
            Match match = regex.Match(xml);
            if (match.Groups.Count != 2)
            {
                return false;
            }

            patente = match.Groups[1].Value;

            Multa m = new Multa();
            m.Importar(xml);


            return true;
        }

        public override string ToString()
        {
            return $"Patente: {patente}, importe total: {ImporteTotal}";
        }

        public int CompareTo(Vehiculos? obj)
        {
            return patente.CompareTo(obj?.patente);
        }
    }
}
