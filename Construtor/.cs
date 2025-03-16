using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Antes eu podia declarar um produto antes de pedir as suas informações
              agora com o construtor para criar um produto eu preciso das informações
              po isso se eu criar por exemplo :Produto p = new Produto("tv",500.00,10);
              iria funcionar , porem agora é preciso usar variaveis auxiliares inves de
              pedir os dados com p.nome,p.preco,p.quantidade .

             * Produto p = new Produto();
             */

            Console.WriteLine("Entre os dados dos produto:");
            Console.Write("Nome:");
            string nome = Console.ReadLine();

            Console.Write("Preço:");
            double  preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade:");
            int quantidade= int.Parse(Console.ReadLine());

            Produto p = new Produto(nome,preco,quantidade);


            Console.Write("Dados do Produto:" + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionados:");
            int qtdAd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtdAd);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizado" + p);

            Console.WriteLine("Digite o numero de produtos a ser removidos:");
            int qtdRe = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtdRe);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizado" + p);


        }
    }
}

// CLasse produto com contrutor e ToString


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










