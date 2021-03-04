using System;
using System.Collections.Generic;
using System.Text;

namespace _8._3_Revisao {
    class Aluno {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public Aluno(string nome, double nota1, double nota2, double nota3) {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public double NotaAnual() {
            return Nota1 + Nota2 + Nota3;
        }

        public string Aprovacao() {

            if (NotaAnual() >= 60 && NotaAnual() <= 100) {
                return "Aprovado";
            }
            else if (NotaAnual() >= 0 && NotaAnual() < 60) {
                return "Negado";
            }
            else {
                return "Valor Inválido";            }
        }

       /* public bool Aprovado() {
            if (NotaAnual() >= 60) {
                return true;
            }
            else {
                return false;
            }
        }
       */

        public double NotaRestante() {
            if ( NotaAnual() >= 60) {
                return 0;
            }
            else {
                return 60 - NotaAnual();
            }
        }

        public override string ToString() {
            return Nome
                + ", Nota Anual = "
                + NotaAnual()
                + ", Nota Restante = "
                + NotaRestante()
                + ", Situação de Aprovação = "
                + Aprovacao();
        }
    }
}
