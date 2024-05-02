namespace Ex07
{
    public abstract class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public double Saldo { get; protected set; }

        protected ContaBancaria(int numeroConta, double saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"\nDepósito de {valor:C2} efetuado com sucesso.");
        }

        public bool Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"\nSaque de {valor:C2} efetuado com sucesso.");
                return true;
            }
            Console.WriteLine("\nSaldo insuficiente para o saque.");
            return false;
        }

        public abstract void ExibirInformacoes();
    }
}
