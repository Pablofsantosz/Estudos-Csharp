using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

         

            Console.WriteLine("Entre os dados dos produto:");
            Console.Write("Nome:");
            string nome = Console.ReadLine();

            Console.Write("Preço:");
            double  preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade:");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //1 construtor(metodo) vai ler todas as informaçoes
            Produto p1 = new Produto(nome,preco,quantidade);
            
            /*2 construtor(metodo) vai ler apenas nome e preço e quantidade vai ser = 0 
                Por que quando nao declaramos nada para a variavel do tipo int ela vale 0.
            */
            Produto p2 = new Produto(nome,preco);

            /*3 construtor(metodo) vai ler apenas nome ,preco e quantidade vai ser = 0.0 e 0
                Por que quando nao declaramos nada para a variavel do tipo int ela vale 0 .
                float(0.0) e int(0)
            */

            Produto p3 = new Produto(nome);



            Console.WriteLine("Dados do Produto 1:" + p1);
            Console.WriteLine("Dados do Produto 2:" + p2);
            Console.WriteLine("Dados do Produto 3:" + p3);




        }
    }
}

// CLasse
using System.Globalization;

namespace Course
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtor
        
        public Produto(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco; 
            this.Quantidade = quantidade;
        }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            // vai interpretar quantidade como se fosse 0
        }
        public Produto(string nome)
        {
            this.Nome = nome;
            // vai interpretar preco como 0.0 e quantidade como se fosse 0
          
        }


        public double Valor_Total_Estoque()
        {
            double total = (Quantidade * Preco);
            return total;
        }


        public void AdicionarProduto(int valorMais)
        {
            Quantidade += valorMais;
        }
        public void RemoverProduto(int valorMenos)
        {
            Quantidade -= valorMenos;

        }

        
        public override string ToString()
        {
            return Nome
                + " ,$"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Unidades ,total :$ "
                + Valor_Total_Estoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}













