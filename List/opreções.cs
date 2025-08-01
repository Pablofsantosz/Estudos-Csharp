
using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma lista do tipo string
            List<string> list = new List<string>();

           
            // Operações básicas com listas (List):
           

            // Add: Adiciona elementos no final da lista.
            list.Add("Maria");
            list.Add("bob");
            list.Add("paula");

            // Insert: Insere elementos em posições específicas.
            list.Insert(3, "pablo");   // Adiciona "pablo" na posição 3
            list.Insert(0, "lorenna"); // Adiciona "lorenna" no início

           
            // Exibir todos os elementos da lista:
          
            Console.WriteLine("Elementos da lista:");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Count: Retorna a quantidade de elementos na lista.
            Console.WriteLine("\nList count: " + list.Count);

         
            // Find: Retorna o primeiro elemento que começa com 'p'
            
            string s1 = list.Find(x => x[0] == 'p');
            Console.WriteLine("\nPrimeiro elemento que começa com 'p': " + s1);


            // FindLast: Retorna o último elemento que começa com 'p'
            string s2 = list.FindLast(x => x[0] == 'p');
            Console.WriteLine("Último elemento que começa com 'p': " + s2);


            // FindIndex: Índice do primeiro elemento que começa com 'p'
            int pos1 = list.FindIndex(x => x[0] == 'p');
            Console.WriteLine("Índice do primeiro elemento que começa com 'p': " + pos1);


            // FindLastIndex: Índice do último elemento que começa com 'p'
            int pos2 = list.FindLastIndex(x => x[0] == 'p');
            Console.WriteLine("Índice do último elemento que começa com 'p': " + pos2);


            // FindAll: Filtra e cria nova lista com nomes de 5 letras
            
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("\nElementos com 5 caracteres:");
            foreach (string b in list2)
            {
                Console.WriteLine(b);
            }

           
            // Remove: Remove um elemento específico ("pablo")
            
            Console.WriteLine("\nLista após remover 'pablo':");
            list.Remove("pablo");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // RemoveAll: Remove todos que começam com 'b'
            
            list.RemoveAll(x => x[0] == 'b');
            Console.WriteLine("\nLista após remover todos que começam com 'b':");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

           
        }
    }
}
