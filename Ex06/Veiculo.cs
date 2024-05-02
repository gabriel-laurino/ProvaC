namespace Ex06
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }

        protected Veiculo(string modelo, int ano, string cor)
        {
            Modelo = modelo;
            Ano = ano;
            Cor = cor;
        }

        public abstract void ExibirInformacoes();
    }
}
