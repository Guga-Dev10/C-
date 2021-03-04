using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace _4._Estoque {
    class Produtos {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalDeEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarQuantidade(int quantidade) {
            Quantidade += quantidade;
        }

        public void DiminuirQuantidade(int quantidade) {
            Quantidade -= quantidade;
        }

        CultureInfo CI = CultureInfo.InvariantCulture;
        public override string ToString() {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CI)
                + ", "
                + Quantidade
                + " unidades, Total = $"
                + ValorTotalDeEstoque().ToString("F2", CI);
        }
    }
}
