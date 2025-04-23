using System;
using System.Globalization;
using Construtor;




namespace Course
{

    class Program
    {
        public static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];
            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());


            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel("+(i+1)+"):");
                Console.Write("Nome aluno:");
                string name = Console.ReadLine();
                Console.Write("Email aluno:");
                string email = Console.ReadLine();
                Console.Write("Quarto Escolhido:");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto]= new Estudante(name, email);
                Console.WriteLine();

            }
            Console.WriteLine("=====RELATORIO===");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                { 
                    Console.WriteLine("Quarto(" + i + "):");
                    Console.WriteLine("Nome Aluno:" + vect[i].Name);
                    Console.WriteLine("Email:" + vect[i].Email);
                    Console.WriteLine("Quarto:" + i);
                    Console.WriteLine();
                    Console.WriteLine();
                }

               
            }
            Console.WriteLine("Busy Romms");
            for(int i = 0; i < 9; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i+":"+vect[i].Name+","+ vect[i].Email);
                }
            }

        }
    }
}

//class estudante


namespace Construtor
{
    internal class Estudante
    {
        public string Name { get; set; }
        public string Email { get; set; }

      

        public Estudante(string name,string email) { 
            this.Name = name;
            this.Email = email;
            
        }
        
    }
}
