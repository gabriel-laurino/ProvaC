using Ex10;

class Program10
{
    static void Main(string[] args)
    {
        IReserva reservaRegular = new ReservaRegular();
        IReserva reservaUpgrade = new ReservaUpgrade();
        IReserva reservaGrupo = new ReservaGrupo();

        Console.WriteLine();
        reservaRegular.ReservarVoo();
        Console.WriteLine(reservaRegular.VerificarStatus());

        Console.WriteLine();
        reservaUpgrade.ReservarVoo();
        Console.WriteLine(reservaUpgrade.VerificarStatus());

        Console.WriteLine();
        reservaGrupo.ReservarVoo();
        Console.WriteLine(reservaGrupo.VerificarStatus());

        Console.WriteLine();
        reservaGrupo.CancelarReserva();
        Console.WriteLine(reservaGrupo.VerificarStatus());
    }
}
