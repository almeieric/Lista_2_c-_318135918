using System;

namespace Exercicio_4
{
    class Program
    {
        static void Triangulo(int ladoBase, int ladoA, int ladoB)
        {
           

                        

            if (ladoBase == ladoA && ladoA == ladoB && ladoB == ladoBase)
            {
                Console.WriteLine("Equilatero");
            } else if (ladoA == ladoB)
            {
                Console.WriteLine("Isoceles");
            } else if (ladoBase != ladoA && ladoA != ladoB && ladoB != ladoBase)
            {
                Console.WriteLine("Escaleno");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insira Base: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sua base é: " + a);


            Console.WriteLine("Insira Lado A: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sua lado A é: " + b);


            Console.WriteLine("Insira Lado B: ");
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sua lado B: " + c);


            Console.Write("\nSeu triangulo é: ");
            Triangulo(a, b, c);


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}  
