namespace Ex07
{
    public class ContaEmpresarial : ContaBancaria
    {
        public double SaldoMinimo { get; private set; }

        public ContaEmpresarial(int numeroConta, double saldoInicial, double saldoMinimo)
            : base(numeroConta, saldoInicial)
        {
            SaldoMinimo = saldoMinimo;
        }

        public bool VerificarSaldoMinimo()
        {
            return Saldo >= SaldoMinimo;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"\nConta Empresarial {NumeroConta}: Saldo {Saldo:C2}, Saldo Mínimo {SaldoMinimo:C2}");
        }
    }
}
