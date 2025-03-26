using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        /
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
        
        //Get (obter) quando voce quiser obter um valor de um atributo usar o get
        //Set (definir/muda) quando voce quer mudar  o valor da variavel .


        //
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(){

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        /* Properties = Sao difinições de metodos encapsulados, porem expondo
           expondo uma sintaxe similar á de atributos e não de metodos 
         */
        public string Nome { 
            get { return _nome; }
            set {
                if (value != null && value.Length > 0)
                {
                    _nome = value;
                }
            }
        }
        /* Usando o parametro "Value" voce estaria usando basicamente
         o parametro que chegaria no metodo Set */
        public double Preco
        { 
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }
        


        /* Comentando por que nao é mais necessario , o metodo get e set
           feitos assim
        */

        /*public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 0)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

         public int GetQuantidade()
        {
            return _quantidade;
        }

        */





        public double Valor_Total_Estoque()
        {
            double total = (_quantidade * _preco);
            return total;
        }


        public void AdicionarProduto(int valorMais)
        {
            _quantidade += valorMais;
        }
        public void RemoverProduto(int valorMenos)
        {
            _quantidade -= valorMenos;
            
        }

        public override string ToString()
        {
            return _nome 
                + " ,$" 
                + _preco.ToString("F2",CultureInfo.InvariantCulture) 
                + ", "
                + _quantidade
                +" Unidades ,total :$ "
                + Valor_Total_Estoque().ToString("F2", CultureInfo.InvariantCulture);
           
        }
        
    }
}




   






