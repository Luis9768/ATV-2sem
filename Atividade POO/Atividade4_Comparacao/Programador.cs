using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade4_Comparacao
{
    public class Programador : Funcionario, ITrabalhador
    {
        public override void trabalhar() => Console.WriteLine($"{nome} está prgramando...");
        public void executarTarefa() => Console.WriteLine($"{nome} concluiu uma tarefa.");
    }
}