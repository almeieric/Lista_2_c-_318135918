using System;

namespace Exercicio_3
{
    class Program
    {
        static bool Par(int c)
        {
            if (c % 2 == 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

    




        static void Main()
        {

           
            Console.WriteLine("é Par?\n");
            int n = 0;
            do
            {
                Console.WriteLine(n + " é " + Par(n));
                n++;
            } while (n <= 10);
            



            
            Console.ReadKey();


          

        }
    }
}
