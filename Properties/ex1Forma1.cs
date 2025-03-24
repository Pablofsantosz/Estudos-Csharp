using System;
using System.Globalization;
using namespaceBanco;
       

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
                Console.WriteLine("Informe o valor do deposito inicial:");
                deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Pessoa = new Banco(Nome,Num_conta,deposito) ;
            }
            else
            {
                Pessoa = new Banco(Nome,Num_conta);
            }

            Console.WriteLine("Dados salvos com sucesso!!");


            Console.WriteLine("Dados da Conta:");
            Console.Write("Numero conta: " + Pessoa.Numero_conta);
            Console.Write(" Nome: " + Pessoa.Nome);
            Console.WriteLine(" Saldo: " + Pessoa.Saldo.ToString("F2",CultureInfo.InvariantCulture));

            Console.WriteLine("///////");
            
            //Inserir Deposito
            Console.WriteLine("Entre com um valor para deposito.");
            aux = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Pessoa.Deposito(aux);

            Console.WriteLine("Dados da Conta:");
            Console.Write("Numero conta: " + Pessoa.Numero_conta);
            Console.Write(" Nome: " + Pessoa.Nome);
            Console.WriteLine(" Saldo: " + Pessoa.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("///////");

            //Saque
            Console.WriteLine("Entre com um valor para saque.");
            aux = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Pessoa.Saque(aux);

            Console.WriteLine("Dados da Conta:");
            Console.Write("Numero conta: " + Pessoa.Numero_conta);
            Console.Write(" Nome: " + Pessoa.Nome);
            Console.WriteLine(" Saldo: " + Pessoa.Saldo.ToString("F2", CultureInfo.InvariantCulture));





        }
    }

}


//Classe



namespace namespaceBanco
{
     public class Banco
    {
        private string _nome;
        private double _numero_conta;
        private double _saldo;

        public Banco(string nome,double numero_conta,double valor_conta)
        {
            this._nome = nome;
            this._numero_conta = numero_conta;
            this._saldo = valor_conta;
        }
        public Banco(string nome, double numero_conta)
        {
            this._nome = nome;
            this._numero_conta = numero_conta;
            this._saldo = 0;

        }

        public string Nome
        {
            get { return this._nome; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nome = value;
                }
            }

        }

        public double Numero_conta
        {
            get { return this._numero_conta; }

        }
        public double Saldo 
        { 
            get { return this._saldo; }

        }

        public void Deposito(double valor)
        {
            _saldo += valor;

        }

        public void Saque(double valor)
        {
            _saldo -= (valor + 5);
        }

    }
}
