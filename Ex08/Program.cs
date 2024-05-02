using Ex08;

class Program08
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Curso ingles = new CursoIngles("Inglês Completo", 120, "Avançado");
        ingles.AdicionarNota(8.5);
        ingles.AdicionarNota(9.2);
        Console.WriteLine(ingles.CalcularMediaNotas());
        Console.WriteLine(ingles.GerarCertificado());
        ingles.ExibirInformacoes();

        Console.WriteLine();
        Curso frances = new CursoFrances("Francês Básico", 60);
        Console.WriteLine(frances.GerarCertificado());
        frances.ExibirInformacoes();
    }
}