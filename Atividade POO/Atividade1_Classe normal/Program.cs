using System.Collections;

namespace Atividade_POO;

class Program: Aluno
{
    static void Main(string[] args)
    {
        Pessoa p = new Pessoa
        {
            name = "Luís",
            idade = 26,
        };
        Aluno a = new Aluno
        {
            name = "Maria",
            idade = 26,
            curso = "Desenvolvimento de Sistemas",
        };

        p.apresentar();
        a.apresentar();

    }
}
