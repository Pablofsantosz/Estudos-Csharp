using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Exemplo 1: Passagem por valor (valor de 'a' não é alterado fora do método)
            int a = 10;
            Calculadora.Triple(a);
            Console.WriteLine("Exemplo 1 - Passagem por valor (sem ref/out): " + a); // Saída: 10

            // Exemplo 2: Passagem por referência com ref (valor de 'b' é alterado fora do método)
            int b = 20;
            Calculadora.TripleRef(ref b);
            Console.WriteLine("Exemplo 2 - Passagem por referência (ref): " + b); // Saída: 60

            // Exemplo 3: Passagem por referência com out (variável deve ser inicializada dentro do método)
            int c = 30;
            int aux;
            Calculadora.TripleOut(c,out aux);
            Console.WriteLine("Exemplo 3 - Passagem por referência (out): " +aux); // Saída: 90



            /*
             Diferença:
                - A variavel passada como parâmetro REF DEVE ter sido iniciada:
                - A variavel passada como parâmetro OUT não precisa ter sido iniciada:

             Conclusao:
                - ambos são similares , mas red é uma forma de fazer o compilador obrigar o usuario a iniciar uma variavel:
                - ambos sao considerados "code  smelss"(desing ruim) nao deve ser usado.


             */
        }
    }
}



//Class:


namespace Course
{
    class Calculadora
    {
        // Método que não altera a variável original (passagem por valor)
        public static void Triple(int x)
        {
            x = x * 3;
        }

        // Método que altera a variável original usando ref (a variável precisa ser inicializada antes)
        public static void TripleRef(ref int x)
        {
            x = x * 3;
        }

        // Método que altera a variável original usando out (não precisa ser inicializada antes)
        public static void TripleOut( int x, out int  z)
        {
            // out exige que a variável seja obrigatoriamente inicializada dentro do método
            z = x * 3;
        }
    }
}


