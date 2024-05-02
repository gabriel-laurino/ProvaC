namespace Ex08
{
    public class CursoFrances : Curso
    {
        public CursoFrances(string nomeCurso, int duracaoHoras)
            : base(nomeCurso, duracaoHoras)
        {
        }

        public override string GerarCertificado()
        {
            return $"Certificado especial de conclusão do curso de Francês {NomeCurso}!";
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Curso de Francês, Duração: {DuracaoHoras} horas");
        }
    }
}
