namespace Ex10
{
    public class ReservaGrupo : IReserva
    {
        public string CodigoReserva { get; private set; }
        private bool statusReserva;

        public ReservaGrupo()
        {
            CodigoReserva = Guid.NewGuid().ToString();
            statusReserva = false;
        }

        public bool ReservarVoo()
        {
            Console.WriteLine("Reserva de voo para grupo grande realizada.");
            statusReserva = true;
            return statusReserva;
        }

        public bool CancelarReserva()
        {
            Console.WriteLine("Reserva para grupo cancelada.");
            statusReserva = false;
            return true;
        }

        public string VerificarStatus()
        {
            return statusReserva ? "Reserva ativa para grupo." : "Reserva não ativa.";
        }
    }
}
