using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _6._Propriedades {
    class Preco {

        CultureInfo CI = CultureInfo.InvariantCulture;

        private string _nome;
        private double _valor;
        private int _quantidade;

        // Construtor Padrão - Sem parâmetros
        public Preco() {
        }

        // Construtor Sobrecarga com dois parâmetros
        public Preco(string nome, double valor) {
            _nome = nome;
            _valor = valor;
            _quantidade = 5;
        }
        // Construtor sobrecarga com Três parâmetros
        public Preco(string nome, double valor, int quantidade) {
            _nome = nome;
            _valor = valor;
            _quantidade = quantidade;
        }

        public string Nome { // Propriedade
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double Valor {
            get { return _valor; }
            set { _valor = value; }
        }

        public int Quantidade {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
        
        public double ValorTotalEmEstoque() {
            double total = _valor * _quantidade;
            return total;
        }

        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome
                + ", Quantidade = "
                + _quantidade
                + ", Valor = $"
                + ValorTotalEmEstoque().ToString("F2", CI);
        }
    }
}
