using System;

namespace Atividade_Sistemas_de_Gestão
{
    public class Reserva
    {
        public Hospede HospedeReserva { get; set; }
        public Quarto QuartoReserva { get; set; }
        public int Dias { get; set; }
        public double ValorTotal { get; set; }

        public Reserva(Hospede HospedeConstrutor, Quarto QuartoConstrutor, int DiasConstrutor)
        {
            HospedeReserva = HospedeConstrutor;
            QuartoReserva = QuartoConstrutor;
            Dias = DiasConstrutor;
        }

        public virtual double CalcularTotal()
        {
            ValorTotal = QuartoReserva.PrecoDiaria * Dias;
            return ValorTotal;
        }

        public virtual string ResumoReserva()
        {
            return
                $"Hóspede {HospedeReserva} está hospedado no quarto {QuartoReserva} por {Dias} dias. Pagando o total de R${ValorTotal}.";
        }
    }
}
