using System;
using System.Globalization;

namespace Course
{

    class Program
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());


            // Cria o vetor na memoria(heap).
            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe o valor na posição" + i);
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            }

            double media = (vect[0] + vect[1] + vect[2]) / 3;
            Console.WriteLine("AVERAGE HEIGHT =" + media.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}