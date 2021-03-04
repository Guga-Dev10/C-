using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _5._Vendas {
    class Produto {

        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Nome;
        public string Vendedor;
        public double Preco; 
        public double Comissao = 0.30;
        public int Quantidade;
        public int QuantidadeDeVendas;

        public Produto() {

        }

        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco, int quantidade,
            string vendedor, int quantidadevendida): this (nome, preco, quantidade) {
            Vendedor = vendedor;
            QuantidadeDeVendas = quantidadevendida;
        }

        public double ValorTotalEmEstoque() {
            double valor = Preco * Quantidade;
            return valor;
        }       
        public double ComissaoVendedor() {
            double comissaovendedor = QuantidadeDeVendas * Preco;
                   comissaovendedor = comissaovendedor * Comissao;
            return comissaovendedor;
        }

        public void AdicionarQuantidade(int quantidade) {
            Quantidade += quantidade;
        }

        public void RetirarQuantidade(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome + ", Quantidade = " + Quantidade + ", Preço = $"
                + ValorTotalEmEstoque().ToString("F2", CI)
                + ", Vendedor = " + Vendedor + ", Quantidade Vendida = " + QuantidadeDeVendas
                + ", Comissão do Vendedor = " + ComissaoVendedor().ToString("F2", CI);
        }
    }
}
