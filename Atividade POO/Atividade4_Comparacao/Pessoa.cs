using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade4_Comparacao
{
    public class Pessoa
    {
        public string nome;
        public void falar() => Console.WriteLine($"{nome} está falando!");
    }
}