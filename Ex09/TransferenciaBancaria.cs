namespace Ex09
{
    public class TransferenciaBancaria : IMetodoPagamento
    {
        public string ContaBancaria { get; set; }
        private bool statusPagamento;

        public TransferenciaBancaria(string contaBancaria)
        {
            ContaBancaria = contaBancaria;
            statusPagamento = false;
        }

        public bool RealizarPagamento(double valor)
        {
            Console.WriteLine($"Tentativa de pagamento de {valor:C2} via transferência bancária.");
            statusPagamento = valor <= 10000; // Limita o pagamento para valores até 10000.
            return statusPagamento;
        }

        public string VerificarStatus()
        {
            return statusPagamento ? "Pagamento confirmado via transferência bancária." : "Pagamento negado ou não realizado via transferência bancária.";
        }
    }
}
