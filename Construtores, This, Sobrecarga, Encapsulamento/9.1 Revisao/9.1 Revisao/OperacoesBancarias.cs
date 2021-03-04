using System;
using System.Collections.Generic;
using System.Text;

namespace _9._1_Revisao {
    class OperacoesBancarias {

        public int NumeroDaConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public OperacoesBancarias() { }

        public OperacoesBancarias(int numero, string nome) {
            NumeroDaConta = numero;
            Nome = nome;
            Saldo = 0.0;
        }

        public OperacoesBancarias(int numero, string nome, double saldo) {
            NumeroDaConta = numero;
            Nome = nome;
            Saldo = saldo;
        }
        public void Deposito(double deposito) {
            Saldo += deposito;
        }

        public void Saque(double saque) {
            Saldo -= saque + 5.00;
        }

        public override string ToString() {
            return "Titular = "
                + Nome
                + "\n"
                + "Conta = "
                + NumeroDaConta
                + "\n"
                + "Saldo = R$"
                + Saldo;
        }
    }
}
