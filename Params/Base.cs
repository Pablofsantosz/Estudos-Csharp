using System;
using System.Globalization;




namespace Course{
    
    class Program
    {
        public static void Main(string[] args)
        {

            int result = Calculadora.Sum(10,20,30,40);
            Console.WriteLine(result);
            //basicamente o parans serve pra quando tem um função onde os parametros variam em quantidade.
            //Serve para resolver esse problema abaixo:

            /*
        Class Program:
            namespace{
                 class Program
                 {
                    public static void Main(string[] args){
                    
                           int s1 = Calculadora.Sum(1, 2);
                           int s2 = Calculadora.Sum(1,2,3);
                           int s3 = Calculadora.Sum(1,2,3,4);

                           Console.WriteLine(s1);
                           Console.WriteLine(s2);
                           Console.WriteLine(s3);
                    }
                 }
            }

         class calculator:
             namespace Course
            {
             class Calculator
             {
                 public static int Sum(int n1,int n2)
                 {
                     return n1 + n2;
                 }
                 public static int Sum(c)
                 {
                     return n1 + n2 + n3;

                 }
                 public static int Sum(int n1, int n2, int n3, int n4)
                 {
                     return n1 + n2 + n3 + n4;
                 }
             }
            }     
             */



            /*Uma forma de resolver com vetor:
              
              namespace Course
            {
                class Program
                {
                    public static void Main(string[] args)
                    {
                        int result = Calculadora.Sum(new int[] {10,20,30,340});

                    }

                }
            }
             namespace Course
            {
                class Calculadora
                {
                    public static int Sum(iny[] numbers)
                    {
                        int sum= 0 ;
                        for(int i = 0 ; i <numbers.Length;i++)
                        {
                            sum += numbers[i];
                        }

                        return sum;

                    }

                }
            }
             
             */

             

            /*Melhor forma usando os Params;
                namespace Course
            {
                class Program
                {
                    public static void Main(string[] args)
                    {
                        int result = Calculadora.Sum(int[] {10,20,30,340});
                        Console.WriteLine(result);

                    }

                }
            }
             namespace Course
            {
                class Calculadora
                {
                     //A palavra params vai avisar para o compilador que voce quer uma função que possar receber uma quantia variavel de valores.
                    public static int Sum(params int[] numbers)
                    {
                        int sum= 0 ;
                        for(int i = 0 ; i <numbers.Length;i++)
                        {
                            sum += numbers[i];
                        }

                        return sum;

                    }

                }
            }
             
             
             
             */


        }
    }
}