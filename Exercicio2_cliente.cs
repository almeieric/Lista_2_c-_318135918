using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    public class Cliente
    {
        private int saldo;
        private int conta;
        private int totalCobrancas;
        private int totalCredito;
        private int limiteCredito;

        public Cliente(int saldo, int conta, int cobrancas, int credito, int limite)
        {
            this.saldo = saldo;
            this.conta = conta;
            this.totalCobrancas = cobrancas;
            this.totalCredito = credito;
            this.limiteCredito = limite;
        }


        public int CalcularNovoSaldo()
        {
            return this.saldo + this.totalCobrancas - this.totalCredito;
        }

        public void AtualizarSaldo()
        {
            this.saldo = CalcularNovoSaldo();
        }

        public bool UltrapassouLimite()
        {
            return this.saldo > this.limiteCredito;
        }
    }

}
