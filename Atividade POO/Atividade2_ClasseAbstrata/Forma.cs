using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade2_ClasseAbstrata
{
    public abstract class Forma
    {
        public abstract double calcularArea();

        public void mostrarTipo()
        {
            Console.WriteLine("Sou uma forma geométrica.");
        }
    }
}