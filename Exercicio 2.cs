using System;

namespace Exercicio_2
{
    class Program
    {

        static void Main()
        {

            int saldo = 0;
            int cobranca = 0;
            int credito = 0;
            int limite = 0;
            int conta = 0;

            Console.WriteLine("Insira numero da conta");
            conta = Int32.Parse(Console.ReadLine());

            
            if(conta == 2)
            {
                saldo = 3000;
                cobranca = 300;
                credito = 400;
                limite = 2000;

            }else if(conta == 3)
            {
                saldo = 2000;
                cobranca = 100;
                credito = 330;
                limite = 2000;
            }


            Cliente c = new Cliente(saldo, conta, cobranca, credito, limite);

            Console.WriteLine(saldo);


            
            Console.WriteLine("seu saldo autal é " + c.CalcularNovoSaldo());

            c.AtualizarSaldo();

            if (c.UltrapassouLimite())
            {
                Console.WriteLine("Limite de Credito Excedido.");
            }

            Console.WriteLine("Pressione algo para sair...");

            Console.ReadKey();

        }
    }
}
