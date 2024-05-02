namespace Ex10
{
    public class ReservaUpgrade : IReserva
    {
        public string CodigoReserva { get; private set; }
        private bool statusReserva;

        public ReservaUpgrade()
        {
            CodigoReserva = Guid.NewGuid().ToString();
            statusReserva = false;
        }

        public bool ReservarVoo()
        {
            Console.WriteLine("Reserva de voo com upgrade de classe realizada.");
            statusReserva = true;
            return statusReserva;
        }

        public bool CancelarReserva()
        {
            Console.WriteLine("Reserva com upgrade cancelada.");
            statusReserva = false;
            return true;
        }

        public string VerificarStatus()
        {
            return statusReserva ? "Reserva ativa com upgrade." : "Reserva não ativa.";
        }
    }
}
