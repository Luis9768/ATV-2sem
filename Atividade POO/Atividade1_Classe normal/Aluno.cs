using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_POO
{
    public class Aluno: Pessoa
    {
        public String curso;
        public override void apresentar()
        {
            Console.WriteLine($"Sou o(a) aluno(a) {name}, tenho {idade} anos e estudo {curso}");
        }
        }
    }
