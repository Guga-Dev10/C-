using System;
using System.Collections.Generic;
using System.Text;

namespace _3._3_Vetor___Exercicio {
    class Dados {

        public string Nome { get; set; }
        public string Email { get; set; }

        public Dados() {

        }
        public Dados(string nome, string email) {
            Nome = nome;
            Email = email;
        }

        public override string ToString() {
            return "Nome = " + Nome + ", Email = " + Email;
        }
    }
}
