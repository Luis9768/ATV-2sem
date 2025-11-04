using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegregacaoInterfaces
{
    public class Estagiario : ITrabalhador
    {
        public void trabalhar() => Console.WriteLine("Estagiario trabalhando...");
    }
}