using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade2_ClasseAbstrata
{
    public class Circulo : Forma
    {
        public double raio;
        public override double calcularArea() => Math.PI * raio * raio;
    }
}