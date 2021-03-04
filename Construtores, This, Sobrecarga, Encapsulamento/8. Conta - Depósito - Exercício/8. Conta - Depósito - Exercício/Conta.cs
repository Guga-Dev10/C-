using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _8._Conta___Depósito___Exercício {
    class Conta {

        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Nome { get; set; }
        public int ContaRegistro { get; private set; }
        public double Saldo { get; private set; }

        public Conta() { }

        public Conta(string nome, int contaregistro, double saldo) {
            Nome = nome;
            ContaRegistro = contaregistro;
            Saldo = saldo;
        }

        public Conta(string nome, int contaRegistro) {
            Nome = nome;
            ContaRegistro = contaRegistro;
        }

        public double AdicionarSaldo(double deposito) {
            Saldo += deposito;
            return Saldo;
        }
        public void Saque(double retirada) {
            Saldo -= retirada;
            Saldo -= 5;
        }

        public override string ToString() {
            return "Nome = "
                + Nome
                + "; Conta = "
                + ContaRegistro
                + "; Saldo = $"
                + Saldo.ToString("F2", CI);
        }
    }
}
