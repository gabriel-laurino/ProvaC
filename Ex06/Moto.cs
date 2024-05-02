namespace Ex06
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

        public Moto(string modelo, int ano, string cor, int cilindrada)
            : base(modelo, ano, cor)
        {
            Cilindrada = cilindrada;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Moto: {Modelo}, Ano: {Ano}, Cor: {Cor}, Cilindrada: {Cilindrada}cc");
        }
    }
}