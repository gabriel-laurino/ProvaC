namespace Ex09
{
    public class CartaoCredito : IMetodoPagamento
    {
        public string NumeroCartao { get; set; }
        private bool statusPagamento;

        public CartaoCredito(string numeroCartao)
        {
            NumeroCartao = numeroCartao;
            statusPagamento = false;
        }

        public bool RealizarPagamento(double valor)
        {
            Console.WriteLine($"Tentativa de pagamento de {valor:C2} com cartão de crédito.");
            statusPagamento = valor <= 5000; // Verifica uma condição para aprovar ou não o pagamento.
            return statusPagamento;
        }

        public string VerificarStatus()
        {
            return statusPagamento ? "Pagamento aprovado no cartão de crédito." : "Pagamento negado no cartão de crédito.";
        }
    }
}
