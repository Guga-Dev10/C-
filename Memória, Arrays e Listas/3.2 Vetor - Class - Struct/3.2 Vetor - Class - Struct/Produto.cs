using System;
using System.Collections.Generic;
using System.Text;

namespace _3._2_Vetor___Class___Struct {
    class Produto {

        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString() {
            return "Nome do Produto = " + Nome + ", Preço = $" + Preco;
        }
    }
}
