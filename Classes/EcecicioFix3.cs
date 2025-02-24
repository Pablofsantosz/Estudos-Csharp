using System;
using System.Globalization;
using Course1._0;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno:");
            aluno.Nome =Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno:");
            aluno.N1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL =" + aluno.Notafinal().ToString("F2", CultureInfo.InvariantCulture));


            if(aluno.Aprovado()==true)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2",CultureInfo.InvariantCulture) + " PONTOS");
            }

            




        }
    }
}


// CLasse


namespace Course1._0
{
    internal class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;


        public double Notafinal()

        {
            double Media_Final = (N1 + N2 + N3);
            return Media_Final;
        }

        public bool Aprovado()
        {
            if (Notafinal() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double NotaRestante()
        {
            if (Aprovado() == true)
            {
                return 0.0;
            }
            else
            {
                return 60.0 - Notafinal();
            }
        }

    }
}















