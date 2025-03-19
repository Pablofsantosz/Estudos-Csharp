using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course1._0
{
    internal class Produto
    {
        /* Uso da palavra this
            - Diferenciar atributos de variaveis locais 
            - Referenciar outro contrutor em outro construtor
            - Passar o proprio objeto como argumento na chamada 
            de um metodo ou construtor.
         
         this esta geralmente com o atributo da classe ,
         this .nome aponta pra heap nome ent o quadradinho nome
         vai receber o nome do paramentro passado

        */
        public string Nome;
        public double Preco;
        public double Quantidade;
        // referenciar outro construtor em um contrutor:
        public Produto() 
        { 
            Quantidade = 0;
            
        }
        public Produto(string nome, double preco) : this() 
        {
            Nome = nome;
            Preco = preco;
            
        }

        public Produto(string nome, double preco, double quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }
    }
}
