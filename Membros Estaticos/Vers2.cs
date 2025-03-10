using System;
using System.Globalization;
using Course2;



// Versao 2 Membros estáticos : Classe Calculadoura com mebros de instância.
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.Write("Informe o valor do raio :");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circuferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("Circuferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi:" + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}


// Classe


namespace Course2
{
    internal class Calculadora
    {
        public double Pi = 3.14;
        
         public double Circuferencia(double r)
        {
            return r * 2 * Pi;
        }
         public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * (r * r * r);
        }
    }
}
