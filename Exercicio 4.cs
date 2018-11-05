using System;

namespace Exercicio_4
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            Triangulo test = new Triangulo();

            Console.WriteLine(test.ChecarTriangulo(a, b, c));
            Console.ReadKey();
        }
    }
    class Triangulo
    {
        private int a;
        private int baset;
        private int b;
        public Triangulo()
        {
            this.a = 0;
            this.baset = 0;
            this.b = 0;
        }

        public string ChecarTriangulo(int a, int baset, int b)
        {
            if (a == baset && baset == b && b == a)
            {
                return "é equilatero";
            }else if(a == baset && a != b)
            {
                return "é isóseles";
            } else if (a != baset && a!= b && b!= baset)
            {
                return "é equilatero";
            }
        }
    }
}
