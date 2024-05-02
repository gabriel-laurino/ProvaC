using Ex09;

class Program09
{
    static void Main(string[] args)
    {
        IMetodoPagamento cartao = new CartaoCredito("1234567890123456");
        IMetodoPagamento boleto = new BoletoBancario("9876543210");
        IMetodoPagamento transferencia = new TransferenciaBancaria("00123-45");

        Console.WriteLine();
        cartao.RealizarPagamento(150.00); // Deve ser aprovado.
        Console.WriteLine(cartao.VerificarStatus());
        Console.WriteLine();
        cartao.RealizarPagamento(15000.00); // Deve ser negado.
        Console.WriteLine(cartao.VerificarStatus());

        Console.WriteLine();
        boleto.RealizarPagamento(300.00);
        Console.WriteLine(boleto.VerificarStatus());

        Console.WriteLine();
        transferencia.RealizarPagamento(45000.00);
        Console.WriteLine(transferencia.VerificarStatus());
    }
}
