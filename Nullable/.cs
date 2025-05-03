using System;

namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             * NULLABLE TYPES - São tipos de valor (ex: structs) que podem armazenar o valor null.
             * 
             * Aplicação comum: campos em bancos de dados que podem ser nulos,
             * como data de nascimento, número de telefone opcional, etc.
             */

            // Duas formas de declarar um tipo nullable:
            // Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;

            // GetValueOrDefault() retorna o valor da variável, ou o valor padrão do tipo (ex: 0.0 para double)
            Console.WriteLine(x.GetValueOrDefault()); // Output: 0
            Console.WriteLine(y.GetValueOrDefault()); // Output: 10.0

            // HasValue retorna true se a variável possui um valor, e false se for null
            Console.WriteLine(x.HasValue); // false
            Console.WriteLine(y.HasValue); // true

            // Acessando o valor usando .Value:
            // IMPORTANTE: Só é seguro usar .Value se HasValue for true. Caso contrário, ocorre exceção.
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("x is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value); // Output: 10.0
            }
            else
            {
                Console.WriteLine("y is null");
            }

            // -------------------------------------------------------

            // Operador de coalescência nula (??):
            // Retorna o valor da esquerda se não for null; caso contrário, retorna o valor da direita.
            Console.WriteLine();

            double? z = null;
            double? p = 10.00;

            double aux1 = z ?? 5.00; // z é null, então aux1 = 5.00
            double aux2 = p ?? 5.00; // p tem valor, então aux2 = 10.00

            Console.WriteLine(aux1); // Output: 5.00
            Console.WriteLine(aux2); // Output: 10.00
        }
    }
}
