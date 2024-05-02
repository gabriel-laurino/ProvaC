using Ex07;

class Program07
{
    static void Main(string[] args)
    {
        var contaCorrente = new ContaCorrente(101, 5000.00, 1000.00);
        var contaPoupanca = new ContaPoupanca(102, 3000.00, 1.5);
        var contaEmpresarial = new ContaEmpresarial(103, 20000.00, 15000.00);

        contaCorrente.ExibirInformacoes();
        contaPoupanca.ExibirInformacoes();
        contaEmpresarial.ExibirInformacoes();

        contaPoupanca.Depositar(500);
        contaPoupanca.AplicarJuros();
        contaPoupanca.ExibirInformacoes();

        if (contaEmpresarial.VerificarSaldoMinimo())
        {
            Console.WriteLine("\nSaldo da conta empresarial está acima do mínimo requerido.");
        }
        else
        {
            Console.WriteLine("\nAtenção: Saldo da conta empresarial abaixo do mínimo!");
        }
    }
}