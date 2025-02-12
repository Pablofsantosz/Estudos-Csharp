using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo X, Y;

            X = new Triangulo();
            Y = new Triangulo();

            Console.WriteLine("Informe os lados do Triangulo x");
            X.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            X.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            X.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Informe os lados do Triangulo y");
            Y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double AreaX = X.AreaT();
            double AreaY = Y.AreaT();

            Console.WriteLine("A area do Triangulo X = " +AreaX.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("A area do Triangulo Y = " +AreaY.ToString("F4", CultureInfo.InvariantCulture));
            
            if(AreaX > AreaY)
            {
                Console.WriteLine("Maior area : triangulo X");

            }
            else if (AreaY > AreaX)
            {
                Console.WriteLine("MAior area : triangulo Y");
            }
            else
            {
                Console.WriteLine("Tamanhos iguais ");
            }
        }
    }
}




    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;


        public double AreaT()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }






