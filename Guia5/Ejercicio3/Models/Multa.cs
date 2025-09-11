namespace Ejercicio3.Models
{
    internal class Multa : IImportante
    {
        public double Importe { get; set; }

        public Multa() { }

        public Multa(double importe) { Importe = importe; }

    }
}
