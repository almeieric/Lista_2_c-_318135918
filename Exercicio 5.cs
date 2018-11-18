using System;

namespace Exercicio_5
{
    class Program
    {

     

        static void Letras(char letra)
        {
            if(letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u' || letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
            {
                Console.WriteLine("é Vogal");
            }
            else
            {
                Console.WriteLine("é Consoante");
            }
        }

        static void Main(string[] args)
        {

            char letra;
            
            
                Console.WriteLine("Insira a letra");
                letra = Convert.ToChar(Console.ReadLine());
            


            Console.Write("\nA letra: " + letra + " ");
            Letras(letra);

            Console.ReadKey();



           
        }
    }
}
