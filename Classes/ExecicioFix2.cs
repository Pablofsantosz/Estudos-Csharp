using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Console.WriteLine("Informe o dados do funcionario");
            Console.Write("Nome:");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salario bruto:");
            funcionario1.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto:");
            funcionario1.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario :" + funcionario1);

            Console.WriteLine("Digite a  porcentagem para aumentar o salario");
            double Porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            funcionario1.AumentarSalario(Porcentagem);

            Console.WriteLine("Dados atulizados do funcionario:"  + funcionario1);


        }
    }
}

// CLASSE


namespace Course
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            double SalarioLiquido = SalarioBruto - Imposto;
            return SalarioLiquido;
        }

        public void AumentarSalario(double num)
        {
            double Porcentagem = (SalarioBruto / 100) * num;
            SalarioBruto += Porcentagem;
        }
        public override string ToString()
        {
            return Nome +
                    "," +
                    "$" +
                    SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}












