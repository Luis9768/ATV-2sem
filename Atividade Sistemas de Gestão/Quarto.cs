using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_Sistemas_de_Gestão
{
    public class Quarto
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public double PrecoDiaria { get; set; }
        public bool Disponivel { get; set; }

        public Quarto(int NumeroConstrutor, string TipoConstrutor, double PrecoDiariaConstrutor)
        {
            Numero = NumeroConstrutor;
            Tipo = TipoConstrutor;
            PrecoDiaria = PrecoDiariaConstrutor;

            Disponivel = true;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Informações do quarto: Número - {Numero}, Tipo - {Tipo}, está disponível? {Disponivel}");
        }

        public void Ocupar()
        {
            if (Disponivel)
            {
                Disponivel = false;
                Console.WriteLine("Quarto acaba de ser ocupado.");
            }

            else
            {
                Console.WriteLine("Quarto já ocupado. Verifique outra disponibilidade.");
            }
        }
        
        public void Liberar()
        {
            if (!Disponivel)
            {
                Disponivel = true;
                Console.WriteLine("Quarto está liberado!");
            }
            else
            {
                Console.WriteLine("Quarto já está disponível.");
            }
        }
    }
}