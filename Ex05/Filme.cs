using System;

public class Filme
{
    public string Titulo { get; private set; }
    public string Genero { get; private set; }
    public double Duracao { get; private set; }
    public bool Disponivel { get; private set; }

    public Filme(string titulo, string genero, double duracao)
    {
        Titulo = titulo;
        Genero = genero;
        Duracao = duracao;
        Disponivel = true; // Inicialmente todos os filmes estão disponíveis
    }

    public void RegistrarLocacao()
    {
        if (Disponivel)
        {
            Disponivel = false;
            Console.WriteLine($"\n--> O filme '{Titulo}' foi locado com sucesso.");
        }
        else
        {
            Console.WriteLine($"\n--> O filme '{Titulo}' não está disponível para locação.");
        }
    }

    public void RegistrarDevolucao()
    {
        Disponivel = true;
        Console.WriteLine($"\n--> O filme '{Titulo}' foi devolvido e está disponível para locação.");
    }

    public void VerificarDisponibilidade()
    {
        if (Disponivel)
        {
            Console.WriteLine($"\n--> O filme '{Titulo}' está disponível para locação.");
        }
        else
        {
            Console.WriteLine($"\n--> O filme '{Titulo}' não está disponível no momento.");
        }
    }
}