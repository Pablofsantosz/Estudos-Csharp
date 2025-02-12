using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa P1, P2;

            P1 = new Pessoa();
            P2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome :");
            P1.Nome = Console.ReadLine();
            Console.Write("Salario:");
            P1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome :");
            P2.Nome = Console.ReadLine();
            Console.Write("Salario:");
            P2.Salario = double.Parse(Console.ReadLine());

            double media = (P1.Salario + P2.Salario) / 2;
            Console.Write("Media salarial = " + media);
        }
    }
}




    class Pessoa
    {
        public string Nome;
        public double Salario;
    }





