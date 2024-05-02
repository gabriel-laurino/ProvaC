namespace Ex08
{
    public class CursoIngles : Curso
    {
        public string Nivel { get; private set; }

        public CursoIngles(string nomeCurso, int duracaoHoras, string nivel)
            : base(nomeCurso, duracaoHoras)
        {
            Nivel = nivel;
        }

        public override double CalcularMediaNotas()
        {
            if (Nivel == "Avançado")
            {
                return base.CalcularMediaNotas() + 0.5;
            }
            return base.CalcularMediaNotas();
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Curso de Inglês - Nível: {Nivel}, Duração: {DuracaoHoras} horas");
        }
    }
}
