using System;
using System.Collections.Generic;
using System.Globalization;


namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de funcionarios que voce vai informar:\n");
            int qt = int.Parse(Console.ReadLine());

            List<funcionario> lista_funcionarios = new List<funcionario>();
        
            for (int i = 0; i < qt; i++)
            {
                Console.WriteLine("Funcionario #"+(i+1));
                funcionario f = new funcionario();

                Console.WriteLine("Nome:");
                f.Name = Console.ReadLine();

                Console.WriteLine("id:");
                f.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("salario:");
                f.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                lista_funcionarios.Add(f);
                Console.WriteLine();

            }

            Console.WriteLine("Lista de Funcionarios");
            foreach (var i in lista_funcionarios)
            {
                Console.WriteLine("Nome: " + i.Name + ", Idade: " + i.Id + ", Salário: " + i.Salario.ToString("C"));

            }

       
            Console.WriteLine("Informe agora o id do funcionario que vai ter o salario aumentado :");
            int id_escolhido = int.Parse(Console.ReadLine());

           

            funcionario busca = lista_funcionarios.Find(func=>func.Id == id_escolhido);
            
            if (busca != null)
            {

                Console.WriteLine("Informe agora quanto em % o salario vai ser aumentado  :");
                double percentual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                busca.aumento_salario(percentual);
                
                Console.WriteLine($"Salario do id #{1} atualizado com sucesso!!",busca.Id);

            }
            else
            {
                Console.WriteLine("id nao está na lista de funcionarios");
            }

            Console.WriteLine("Lista de Funcionarios Atualizzada!");
            foreach (var i in lista_funcionarios)
            {
                Console.WriteLine("Nome: " + i.Name + ", Idade: " + i.Id + ", Salário: " + i.Salario.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}




// Classe:


namespace List
{
     class funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salario { get; set; }



        public void aumento_salario(double porcetagem)
        {
            Salario += Salario * porcetagem / 100.0;

        }
    }
    




}
