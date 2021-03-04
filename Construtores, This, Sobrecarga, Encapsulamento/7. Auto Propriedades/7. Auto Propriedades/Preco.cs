using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _7._Auto_Propriedades {
    class Preco {

        CultureInfo CI = CultureInfo.InvariantCulture;
       
        //Atributo Privado
        private string _nome;

        // Propriedades autoimplementadas
        public double Valor { get; private set; }
        public int Quantidade { get; private set; }

        // Construtor Padrão - Sem parâmetros
        public Preco() {
        }

        // Construtor Sobrecarga com dois parâmetros
        public Preco(string nome, double valor) {
            _nome = nome;
            Valor = valor;
            Quantidade = 5;
        }
        // Construtor sobrecarga com Três parâmetros
        public Preco(string nome, double valor, int quantidade) {
            _nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        public string Nome { // Propriedade Manual
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        // Métodos
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
            return _nome
                + ", Quantidade = "
                + Quantidade
                + ", Valor = $"
                + ValorTotalEmEstoque().ToString("F2", CI);
        }
    }
}
