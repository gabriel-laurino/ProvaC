namespace Ex07
{
    public class ContaCorrente : ContaBancaria
    {
        public double LimiteChequeEspecial { get; private set; }

        public ContaCorrente(int numeroConta, double saldoInicial, double limiteChequeEspecial)
            : base(numeroConta, saldoInicial)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"\nConta Corrente {NumeroConta}: Saldo {Saldo:C2}, Limite Cheque Especial {LimiteChequeEspecial:C2}");
        }
    }
}
