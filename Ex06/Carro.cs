namespace Ex06
{
    public class Carro : Veiculo
    {
        public int NumeroDePortas { get; set; }

        public Carro(string modelo, int ano, string cor, int numeroDePortas)
            : base(modelo, ano, cor)
        {
            NumeroDePortas = numeroDePortas;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Modelo}, Ano: {Ano}, Cor: {Cor}, Portas: {NumeroDePortas}");
        }
    }
}