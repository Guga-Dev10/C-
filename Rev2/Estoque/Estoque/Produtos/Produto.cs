using System.Globalization;

namespace Estoque.Produtos
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
        public double valorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int qte)
        {
            Quantidade += qte;
        }
        public void RemoverProdutos(int qte)
        {
            Quantidade -= qte;
        }
        public override string ToString()
        {
            return "\nNome = "
                + Nome
                + "\nPreço = $"
                + Preco
                + "\nQuantidade = "
                + Quantidade.ToString("F2", CultureInfo.InvariantCulture)
                + "\nValor total em estoque = $"
                + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
