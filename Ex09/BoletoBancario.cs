namespace Ex09
{
    public class BoletoBancario : IMetodoPagamento
    {
        public string CodigoBoleto { get; set; }
        private bool statusPagamento;

        public BoletoBancario(string codigoBoleto)
        {
            CodigoBoleto = codigoBoleto;
            statusPagamento = false;
        }

        public bool RealizarPagamento(double valor)
        {
            Console.WriteLine($"Tentativa de pagamento de {valor:C2} via boleto bancário.");
            statusPagamento = true; // Todos os pagamentos vão ser verdadeiros aqui.
            return statusPagamento;
        }

        public string VerificarStatus()
        {
            return statusPagamento ? "Pagamento confirmado via boleto bancário." : "Pagamento pendente ou não realizado via boleto bancário.";
        }
    }
}
