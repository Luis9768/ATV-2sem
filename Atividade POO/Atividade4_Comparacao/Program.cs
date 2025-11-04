namespace Atividade4_Comparacao;

class Program
{
    static void Main(string[] args)
    {
        Programador dev = new Programador { nome = "Luís" };
        dev.trabalhar();
        dev.executarTarefa();

        Pessoa p = new Pessoa { nome = "André" };
        p.falar();
    }
}
