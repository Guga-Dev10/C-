using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Estoque
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Estoque()
        {
        }

        public Estoque(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int qte)
        {
            Quantidade += qte;
        }
        public void RemoverProdutos(int qte)
        {
            Quantidade += qte;
        }

        public override string ToString()
        {
            return "Nome = "
                + Nome
                + "\nValor Total = "
                + ValorTotalEmEstoque()
                + "\nQuantidade = "
                + Quantidade;
        }
    }
}
