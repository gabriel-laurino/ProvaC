namespace Ex07
{
    public class ContaPoupanca : ContaBancaria
    {
        public double TaxaJuros { get; private set; }

        public ContaPoupanca(int numeroConta, double saldoInicial, double taxaJuros)
            : base(numeroConta, saldoInicial)
        {
            TaxaJuros = taxaJuros;
        }

        public void AplicarJuros()
        {
            Saldo += Saldo * TaxaJuros / 100;
            Console.WriteLine($"\n\nJuros aplicados à poupança. Saldo atual: {Saldo:C2}");
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"\nConta Poupança {NumeroConta}: Saldo {Saldo:C2}, Taxa de Juros {TaxaJuros}% ao ano");
        }
    }
}
