namespace Ex08
{
    public abstract class Curso
    {
        public string NomeCurso { get; private set; }
        public int DuracaoHoras { get; private set; }
        public List<double> Notas { get; set; }

        protected Curso(string nomeCurso, int duracaoHoras)
        {
            NomeCurso = nomeCurso;
            DuracaoHoras = duracaoHoras;
            Notas = new List<double>();
        }

        public void AdicionarNota(double nota)
        {
            Notas.Add(nota);
        }

        public virtual double CalcularMediaNotas()
        {
            if (Notas.Count == 0) return 0;
            return Notas.Average();
        }

        public virtual string GerarCertificado()
        {
            return $"Certificado do curso {NomeCurso} concluído com sucesso!";
        }

        public abstract void ExibirInformacoes();
    }
}
