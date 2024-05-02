namespace Ex06
{
    public class Bicicleta : Veiculo
    {
        public int NumeroDeMarchas { get; set; }

        public Bicicleta(string modelo, int ano, string cor, int numeroDeMarchas)
            : base(modelo, ano, cor)
        {
            NumeroDeMarchas = numeroDeMarchas;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Bicicleta: {Modelo}, Ano: {Ano}, Cor: {Cor}, Marchas: {NumeroDeMarchas}");
        }
    }
}