using System;

namespace Exercicio_6
{
    class Program
    {
        static bool primo(int c)
        {
            if ((c % 2 != 0 && c / 2 < 2) || (c % 3 != 0 && c / 3 < 3) || (c % 5 != 0 && c / 5 < 5) || (c % 7 != 0 && c / 7 < 7) || ( c % 11 != 0 && c/ 11 < 11))
            {
                return true;

            }
            else
            {
                return false;
            }
        }




        static void Main(string[] args)
        {

            Console.WriteLine("é Primo?\n");
            int n = 1;
            do
            {
                Console.WriteLine(n + " é " + primo(n));
                n++;
            } while (n <= 500);





            Console.ReadKey();



        }
    }
}
