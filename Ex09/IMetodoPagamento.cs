namespace Ex09
{
    public interface IMetodoPagamento
    {
        bool RealizarPagamento(double valor);
        string VerificarStatus();
    }
}
