using Ex04;

class Program04
{
    static void Main(string[] args)
    {
        Produto sapato = new Produto("Sapato", 99.99m, 10);
        Console.WriteLine($"\nProduto inicial: {sapato.Nome}, Preço: {sapato.Preco:C2}, Estoque: {sapato.QuantidadeEmEstoque} unidades");

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Adicionar ao estoque");
            Console.WriteLine("2 - Remover do estoque");
            Console.WriteLine("3 - Mostrar valor e quantidade total em estoque");
            Console.WriteLine("4 - Sair");
            Console.Write("\nDigite sua opção: ");
            string opcao = Console.ReadLine() ?? "";

            switch (opcao)
            {
                case "1":
                    Console.Write("\nDigite a quantidade a adicionar: ");
                    int quantidadeAdicionar = int.Parse(Console.ReadLine() ?? "");
                    sapato.AdicionarEstoque(quantidadeAdicionar);
                    break;
                case "2":
                    Console.Write("\nDigite a quantidade a remover: ");
                    int quantidadeRemover = int.Parse(Console.ReadLine() ?? "");
                    sapato.RemoverEstoque(quantidadeRemover);
                    break;
                case "3":
                    Console.WriteLine($"\nQuantidade total em estoque: {sapato.QuantidadeEmEstoque} unidades");
                    Console.WriteLine($"Valor total em estoque: {sapato.ValorTotalEmEstoque():C2}");
                    break;
                case "4":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("\nOpção inválida, tente novamente.");
                    break;
            }
        }

        Console.WriteLine("Programa encerrado. Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}