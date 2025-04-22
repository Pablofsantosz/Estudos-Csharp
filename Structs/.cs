using System;

namespace Course{
    
    class Program
    {
        public static void Main(string[] args)
        {
            /*Diferente das classes as structs sao tipo valor ,onde elas podem ser iniciadas
            dessa forma(sem o new ,que é como criamos a heap da classe para inserir os valores)
            , mas o tipo struct tbm aceita o tipo new  é possivel iniciar a variavel P entao
            tem duas formas de ser iniciado.
             */

            Point P;
            P.X = 10;
            P.Y = 20;
            Console.WriteLine(P);
            P = new Point();
            Console.WriteLine(P);



            //VALORES PADRÂO
            /* Quando alocamos (NEW) qualquer tipo estruturado(classe,struct,array)
              ,sao atribuidos valores padão aos seus elementos.

                -numeros:0
                -bool: false
                -char:caractere codigo 0
                -objeto:NUll


            Obs: Uma variavel apenas declara , mas não instanciada inicia em estado "nao
            atribuida",e o próprio compilador não permite que ela seja acessada.
             
             */

             


        }
    }
}

//Classe


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    //Struct == tipo valor
    //Classe == tipo referencia
    
    struct Point
    {
        public int X;
        public int Y;


        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";    
        }
    }
}
