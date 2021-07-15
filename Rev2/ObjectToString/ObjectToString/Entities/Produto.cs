using System.Globalization;

namespace ObjectToString.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public void AumentarQuantidade(int qte)
        {
            Quantidade += qte;
        }
        public void DiminuirQuantidade(int qte)
        {
            Quantidade -= qte;
        }
        public double ValorTotal()
        {
            return Preco * Quantidade;
        }
        public override string ToString()
        {
            return "Dados do Estoque \n"
                +"\nProduto: "
                + Nome
                + "\nPreço: $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + "\nQuantidade: "
                + Quantidade
                + "\nValor Total: $"
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
