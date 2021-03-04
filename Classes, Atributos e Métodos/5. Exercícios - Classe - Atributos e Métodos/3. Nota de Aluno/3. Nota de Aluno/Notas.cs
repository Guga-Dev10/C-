using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Nota_de_Aluno {
    class Notas {

        public string Nome;
        public double Bi1;
        public double Bi2;
        public double Bi3;

        public double NotaAnual() {
            double nota = Bi1 + Bi2 + Bi3;
            return nota;
        }

        public string Aprovado() {
            if (NotaAnual() >= 60) {
                return "Aprovado!";
            }
            else {
                double faltam = 60 - NotaAnual();
                return "Reprovado!"
                        + " Faltam = "
                        + faltam
                        + " pontos";
            }
        }
        public override string ToString() {
            return "Aluno = "
                + Nome
                + "; Nota Final = "
                + NotaAnual()
                + "; "
                + Aprovado();
        }
    }
}

