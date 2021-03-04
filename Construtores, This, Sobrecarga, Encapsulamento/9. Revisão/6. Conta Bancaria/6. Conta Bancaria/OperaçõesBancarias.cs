using System;
using System.Collections.Generic;
using System.Text;

namespace _6._Conta_Bancaria {
    class OperaçõesBancarias {

        public string Nome { get; set; }
        public int Conta { get; private set; }
        public double Saldo { get; private set; }

        public OperaçõesBancarias() {

        }
        public OperaçõesBancarias(string nome, int conta) {
            Nome = nome;
            Conta = conta;
            Saldo = 0;
        }
        public OperaçõesBancarias(string nome, int conta, double saldo) {
            Nome = nome;
            Conta = conta;
            Saldo = saldo;
        }

        public void Deposito(double deposito) {
             Saldo += deposito;
        }
        public void Saque(double saque) {
            Saldo = Saldo - saque - 5;
        }
    }
}
