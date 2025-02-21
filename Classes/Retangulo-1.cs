using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("entre com a largura e  altura do retangulo");
            Console.Write("Altura:");
            retangulo.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Largura:");
            retangulo.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            Console.WriteLine("Area = " + retangulo.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + retangulo.Perimetro().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + retangulo.Diagonal().ToString("F2",CultureInfo.InvariantCulture));



        }
    }
}



using System.Globalization;

namespace Course
{
     class Retangulo

    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            double A = Altura * Largura;
            return A;
        }
        public double Perimetro()
        {
            double P = 2 * (Altura + Largura);
            return P;
        }
        public double Diagonal()
        {
            double D = ((Altura * Altura) + (Largura * Largura));
            return Math.Sqrt(D);
        }
        
    }
}














