using System;
using System.Globalization;
using Course1._0;


namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar ?");
            double cotacao_dolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares voce vai comprar ?");
            double qt_dolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double aux = CoversaoDeMoeda.conversao_dolar(qt_dolar, cotacao_dolar);
            Console.WriteLine("O valor a ser pago em reais é = " + aux.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}




// Classe


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course1._0
{
    internal class CoversaoDeMoeda
    {
        static double calcular_taxa(double  valor_sem_taxa)
        {
            double taxa = (valor_sem_taxa * 6) / 100;
            double valortotal = valor_sem_taxa + taxa;
            return valortotal;
        }
         public static  double conversao_dolar(double valor , double cotacao)
        {
            return calcular_taxa(valor * cotacao);
        }
    }
}
