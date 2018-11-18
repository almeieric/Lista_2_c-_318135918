using System;

namespace Exercicio_6
{
    class Program
    {
        static public bool primo(int n)
        {

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        
        
            
               
          



        static void Main(string[] args)
        {

            Console.WriteLine("é Primo?\n");
            Console.WriteLine("Insira um numero");
            int n = Int32.Parse(Console.ReadLine());


            if(primo(n) == true)
            {
                Console.WriteLine("O número: " + n + " é um número primo");
            }
            else
            {
                Console.WriteLine("O número: " + n + " não é um número primo");
            }
           
            





            Console.ReadKey();



        }
    }
}
