namespace Atividade_Sistemas_de_Gestão;

class Program
{
    static void Main(string[] args)
    {
        Hospede h1 = new Hospede("515.565.999-63", "Luma", "11945236998");
        Hospede h2 = new Hospede("Luis", "526.623.441-98", "11952365236");

        Quarto quarto1 = new Quarto(52,"Suíte",130);
        Quarto quarto2 = new Quarto(53,"Duplo",200);

        Reserva reserva1 = new Reserva(h1, quarto1, 3);
        ReservaVip rv = new ReservaVip(h1, quarto2, 4, 10);

        List<Reserva> reservas = new List<Reserva> { reserva1, rv };
        foreach (var reserva in reservas)
        {
            reserva.CalcularTotal();
            Console.WriteLine(reserva.ResumoReserva());
        }
        
    }
}
