using System;
using System.Globalization;


// Versao 1 Membros estáticos : Métodos na própria classe do programa.
namespace Course
{
    class Program
    {

        static  double Pi = 3.14;
        /* No caso do uso do Pi Precisa ser static por que eu to usando o Pi
         * numa operação estatica.
         */
        static void Main(string[] args)
        {
            Console.Write("Informe o valor do raio :");
            double raio =double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circ = Circuferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circuferencia: " + circ.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi:" + Pi.ToString("F2",CultureInfo.InvariantCulture));
        }
        static double Circuferencia (double r)
        {
            return r * 2 * Pi; 
        }
        static double Volume(double r)
        {
            return 4.0 /3.0 *Pi * (r*r*r);
        }

    }
}

