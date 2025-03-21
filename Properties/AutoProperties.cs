using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        /* Properties = Sao difinições de metodos encapsulados, porem expondo
           expondo uma sintaxe similar á de atributos e não de metodos 
         */
        static void Main(string[] args)
        {
            Produto p = new Produto("tv", 500.00, 10);

            p.Nome = "T";
            // Vai dar erro or que na propriedade do Preco so tem o get nao o set.
            //p.Preco = 400.00;

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);

           

        }
    }
}


// Classe Produto

using System.Globalization;

namespace Course
{
    internal class Produto
    {





        private string _nome;
        public double Preco { get; private set; }
        public  int Quantidade { get; private set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 0)
                {
                    _nome = value;
                }
            }
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
            return _nome
                + " ,$"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Unidades ,total :$ "
                + Valor_Total_Estoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
