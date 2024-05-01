using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Filme> filmes = new List<Filme>
        {
            new Filme("Velozes e Furiosos", "Sci-fi", 148),
            new Filme("Dora Aventureira", "Aventura", 136),
            new Filme("Super Aulas de C#", "Terror", 155)
        };

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Verificar disponibilidade de um filme");
            Console.WriteLine("2 - Registrar locação de um filme");
            Console.WriteLine("3 - Registrar devolução de um filme");
            Console.WriteLine("4 - Sair");
            Console.Write("\nDigite sua opção: ");
            string opcao = Console.ReadLine() ?? "";

            switch (opcao)
            {
                case "1":
                    Filme? filmeParaVerificar = EscolherFilme(filmes);
                    filmeParaVerificar?.VerificarDisponibilidade();
                    break;
                case "2":
                    Filme? filmeParaLocar = EscolherFilme(filmes);
                    filmeParaLocar?.RegistrarLocacao();
                    break;
                case "3":
                    Filme? filmeParaDevolver = EscolherFilme(filmes);
                    filmeParaDevolver?.RegistrarDevolucao();
                    break;
                case "4":
                    Console.WriteLine("\nPrograma encerrado.");
                    return;
                default:
                    Console.WriteLine("\nOpção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static Filme? EscolherFilme(List<Filme> filmes)
    {
        Console.WriteLine("\nEscolha um filme:");
        for (int i = 0; i < filmes.Count; i++)
        {
            Console.WriteLine($"\n{i + 1} - {filmes[i].Titulo}");
        }
        Console.Write("\nDigite o número do filme: ");
        if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= filmes.Count)
        {
            return filmes[indice - 1];
        }
        else
        {
            Console.WriteLine("\nOpção de filme inválida.");
            return null;
        }
    }
}
