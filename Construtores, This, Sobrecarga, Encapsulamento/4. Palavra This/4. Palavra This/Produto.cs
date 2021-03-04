using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Palavra_This {
    class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() {
            Quantidade = 5;
        }

        /*
        public Produto(string Nome, double Preco, int Quantidade) {
            this.Nome = Nome;     // A palavra This serve para separar os Atributos dos                        
            this.Preco = Preco;   // parâmetros quando necessário.
            this.Quantidade = Quantidade;
        }
        */

        public Produto(string nome, double preco) : this() {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString() {
            return Nome
                + ", "
                + Preco
                + ", "
                + Quantidade;
        }
    }
}

