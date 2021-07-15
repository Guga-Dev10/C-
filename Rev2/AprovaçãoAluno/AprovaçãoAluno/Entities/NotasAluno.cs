using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovaçãoAluno.Entities
{
    class NotasAluno
    {
        public string Nome { get; set; }
        public double Semestre1 { get; set; }
        public double Semestre2 { get; set; }
        public double Semestre3 { get; set; }

        public NotasAluno (string nome, double n1, double n2, double n3)
        {
            Nome = nome;
            Semestre1 = n1;
            Semestre2 = n2;
            Semestre3 = n3;
        }

        public double NotaFinal()
        {
            return Semestre1 + Semestre2 + Semestre3;
        }
        public bool Aprovado()
        {   
            if (NotaFinal() >= 60 && NotaFinal() <= 100)
            {
                return true;
            }
            else if (NotaFinal() < 60 && NotaFinal() >= 0)
            {
                return false;
            }
            return Aprovado();
        }

        public string NotaRestante()
        {
            if (Aprovado())
            {
                return "Aluno aprovado!!"; 
            }
            else
            { 
                double resto = 60 - NotaFinal();
                return "Aluno Reprovado!! Ainda restam: "
                    + resto;
            }
        }


        public override string ToString()
        {
            return "Dados do Aluno no semestre\n"
                + "\nNome do Aluno: "
                + Nome
                + "\nNota no 1º Semestre: "
                + Semestre1
                + "\nNota no 2º Semestre: "
                + Semestre2
                + "\nNota no 3º Semestre: "
                + Semestre3
                + "\nNota final: "
                + NotaFinal()
                + "\nAprovação: "
                + NotaRestante();
        }
    }
}
