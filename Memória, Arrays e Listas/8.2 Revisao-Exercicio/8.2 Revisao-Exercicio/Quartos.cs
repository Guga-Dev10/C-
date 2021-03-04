using System;
using System.Collections.Generic;
using System.Text;

namespace _8._2_Revisao_Exercicio {
    class Quartos {

        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumeroQuarto { get; set; }

        public override string ToString() {
            return "Estudante = "
                + Nome
                + "\n"
                + "Email = "
                + Email
                + "\n"
                + "Numero do Quarto = "
                + NumeroQuarto;
        }
    }
}
