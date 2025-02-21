using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Entre os dados dos produto:");
            Console.Write("Nome:");
            p.Nome = Console.ReadLine();
            Console.Write("Preço:");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade:");
            p.Quantidade = int.Parse(Console.ReadLine());

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

//Classe produto:



using System.Globalization;

namespace Course
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


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

        /* Toda classe em C# é uma subclasse da classe Object
          ->Object possui os seguintes metodos:
          -GetType:retorna o tipo do objeto.
          -Equals:compara-se se o objeto é igual a outro.
          -GetHashCode:retorna um codigo hash do projeto.
          -ToString: Converte o objeto para string.
          
                    */
        //Macete de sobreprosição
        //A logica de tranforma um produto para string
        // Overide = indica que essa operação vem de outra classe:

        /*Antes quando eu printava " Console.Write("Dados do Produto:" + p);" na main aparecia o namespace.procuto,
          agora quando for printar ele implicitamente vai chamar a função to string e vai ser printado certinho .
         */
        public override string ToString()
        {
            return Nome 
                + " ,$" 
                + Preco.ToString("F2",CultureInfo.InvariantCulture) 
                + ", "
                + Quantidade
                +" Unidades ,total :$ "
                + Valor_Total_Estoque().ToString("F2", CultureInfo.InvariantCulture);
           
        }
        
    }
}




   






