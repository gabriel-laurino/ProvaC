namespace Ex08
{
    public class CursoEspanhol : Curso
    {
        public CursoEspanhol(string nomeCurso, int duracaoHoras)
            : base(nomeCurso, duracaoHoras)
        {
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Curso de Espanhol, Duração: {DuracaoHoras} horas");
        }
    }
}
