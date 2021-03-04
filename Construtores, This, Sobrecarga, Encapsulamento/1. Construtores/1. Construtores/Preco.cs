using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _1._Construtores {
    class Preco {

        CultureInfo CI = CultureInfo.InvariantCulture; 

        public string Nome;
        public double Valor;
        public int Quantidade;

        public Preco(string nome, double valor, int quantidade) {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }
        public double ValorTotalEmEstoque() {
            double total = Valor * Quantidade;
            return total;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome
                + ", Quantidade = "
                + Quantidade
                + ", Valor = $"
                + ValorTotalEmEstoque().ToString("F2", CI);
        }
    }
}
