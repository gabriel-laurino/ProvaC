public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int QuantidadeEmEstoque { get; private set; }

    public Produto(string nome, decimal preco, int quantidadeEmEstoque)
    {
        Nome = nome;
        Preco = preco;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            QuantidadeEmEstoque += quantidade;
            Console.WriteLine($"\n{quantidade} unidades adicionadas ao estoque de {Nome}.");
        }
        else
        {
            Console.WriteLine("\nQuantidade inválida para adicionar ao estoque.");
        }
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade > 0 && quantidade <= QuantidadeEmEstoque)
        {
            QuantidadeEmEstoque -= quantidade;
            Console.WriteLine($"\n{quantidade} unidades removidas do estoque de {Nome}.");
        }
        else
        {
            Console.WriteLine("\nQuantidade inválida ou insuficiente no estoque para remoção.");
        }
    }

    public decimal ValorTotalEmEstoque()
    {
        return QuantidadeEmEstoque * Preco;
    }
}
