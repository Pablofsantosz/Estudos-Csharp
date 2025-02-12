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
            Console.Write("Idade :");
            P1.Idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome :");
            P1.Nome = Console.ReadLine();
            Console.Write("Idade :");
            P1.Idade = int.Parse(Console.ReadLine());

            if(P1.Idade > P2.Idade)
            {
                Console.WriteLine("Pessoa mais velha :" + P1.Nome);

            }
            else if(P2.Idade > P1.Idade)
            {
                Console.WriteLine("Pessoa mais velha :" + P2.Nome);
            }
            else
            {
                Console.WriteLine("Idade iguais");
            }



        }
    }
}

namespace Espaço
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

    }
}