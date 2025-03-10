using System;
using System.Globalization;
using Course2;



// Versao 3 Membros estáticos : 
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.Write("Informe o valor do raio :");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circuferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circuferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi:" + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
/*
 1-A Classe Não Precisa de Estado de Instância
 A classe Calculadora não armazena informações específicas para cada objeto criado.
Ela apenas fornece funções matemáticas que podem ser chamadas diretamente,sem 
necessidade de criar instâncias
2-Evita a Criação Desnecessária de Objetos
Como todos os métodos e o atributo Pi são estáticos, eles pertencem à própria classe
, e não a uma instância dela. Isso significa que você pode chamar os métodos diretamente
sem precisar criar um objeto:
 */
//Isso faz muito sentido pq as operações sao independentes

 // Classe
 

namespace Course2
{
    internal class Calculadora
    {
        public static double Pi = 3.14;
        
         public  static double Circuferencia(double r)
        {
            return r * 2 * Pi;
        }
         public static  double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * (r * r * r);
        }
    }
}
