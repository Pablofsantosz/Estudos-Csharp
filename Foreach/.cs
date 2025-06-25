using System;


namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // O foreach é um sintaxe para percorrer coleções(listas,vetores outros tipo de estruturas de dados )
            string[] vect = new string[] { "pablo", "felipe", "pedro" };
            foreach (string ve in vect)
            {
                Console.WriteLine(ve);
            }

        }
    }


}