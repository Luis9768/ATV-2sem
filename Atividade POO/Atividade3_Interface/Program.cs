using System.Net.Http.Headers;

namespace Atividade3_Interface;

class Program
{
    static void Main(string[] args)
    {
        Animal c = new Cachorro();
        Animal g = new Gato();

        c.emitirSom();
        g.emitirSom();
    }
}
