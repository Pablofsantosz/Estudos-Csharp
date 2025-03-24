using System;
using System.Collections.Concurrent;
using System.Globalization;
using namespaceBanco;
       
//Usando Proproties
namespace Course
{
    public class Program 
    { 
        public static void Main(string[] args)
        {
            double Num_conta;
            string Nome;
            double deposito;
            char op;
            double aux;
            Banco Pessoa;


            Console.WriteLine("Informe os dados do Cadastro");

            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Numero da conta: ");
            Num_conta = double.Parse(Console.ReadLine());
            Console.Write("Deseja  fazer um valor inicial de deposito (s)Sim ou (n)Nao:");
            op = Console.ReadLine().ToLower()[0];
            //Ler a primeira letra 

            if (op =='s' || op == 'S')
            {
                Console.Write("Informe o valor do deposito inicial:");
                deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Pessoa = new Banco(Nome,Num_conta,deposito) ;
            }
            else
            {
                Pessoa = new Banco(Nome,Num_conta);
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(Pessoa);

            Console.WriteLine();
            Console.WriteLine();


            //Inserir Deposito 
            Console.Write("Entre com um valor para deposito: ");
            aux = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Pessoa.Deposito(aux);


            Console.WriteLine("Dados da Conta Atualizados:");
            Console.WriteLine(Pessoa);

            

            //Saque
            Console.Write("Entre com um valor para saque: ");
            aux = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Pessoa.Saque(aux);

            Console.WriteLine("Dados da Conta atualizados:");
            Console.WriteLine(Pessoa);




        }
    }

}
// classe 




using System.Globalization;

namespace namespaceBanco
{
     public class Banco
    {
        public double Numero_Conta { get;private set; }
        public string Titular { get; set; }
        public double Saldo { get;private set; }


        public Banco(string nome, double numero_conta)
        {
            Titular = nome;
            Numero_Conta = numero_conta;


        }
        public Banco(string nome,double numero_conta,double valor_conta):this(nome,numero_conta)
        {
           
            Saldo = valor_conta;
        }


        public void Deposito(double valor)
        {
            Saldo += valor;

        }

        public void Saque(double valor)
        {
            Saldo -= (valor + 5);
        }
        public override string ToString()
        {
            return "Conta "
                    + Numero_Conta
                    + ",Titular:"
                    + Titular
                    + ", Saldo:$"
                    + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
