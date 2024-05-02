namespace Ex10
{
    public class ReservaRegular : IReserva
    {
        public string CodigoReserva { get; private set; }
        private bool statusReserva;

        public ReservaRegular()
        {
            CodigoReserva = Guid.NewGuid().ToString();
            statusReserva = false;
        }

        public bool ReservarVoo()
        {
            Console.WriteLine("Reserva de voo regular realizada.");
            statusReserva = true;
            return statusReserva;
        }

        public bool CancelarReserva()
        {
            Console.WriteLine("Reserva regular cancelada.");
            statusReserva = false;
            return true;
        }

        public string VerificarStatus()
        {
            return statusReserva ? "Reserva ativa." : "Reserva não ativa.";
        }
    }
}
