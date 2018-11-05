using System;

namespace Trabalhoo
{
    class Exercicio1

    {
        static void Main(string[] args)


        {

            int unidade = 0;
            int dezena = 0;
            int centena = 0;
            int milhar = 0;
            int restoDivisao = 0;
            int quociente = 0;

            const int DECIMAL = 10;

            const int cript = 7;

            Console.WriteLine("insira dados");
            int dadosC = Int32.Parse(Console.ReadLine());

            //unidades
            restoDivisao = dadosC % DECIMAL;
            quociente = (dadosC + cript) / DECIMAL;
            unidade = restoDivisao;

            //dezena
            restoDivisao = quociente % DECIMAL;
            quociente = (quociente + cript) / DECIMAL;
            dezena = restoDivisao;


            //dezena
            restoDivisao = quociente % DECIMAL;
            quociente = (quociente + cript) / DECIMAL;
            centena = restoDivisao;

            //milhar
            restoDivisao = quociente % DECIMAL;
            quociente = (quociente + cript) / DECIMAL;
            milhar = restoDivisao;


            Console.WriteLine("Seu Número: {0}{1}{2}{3}", dezena ,  unidade , milhar,  centena );

            Console.ReadKey();
        }
    }
}
