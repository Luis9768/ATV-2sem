namespace Atividade2_ClasseAbstrata;

class Program
{
    static void Main(string[] args)
    {
        Retangulo r = new Retangulo { largura = 5, altura = 3 };
        Circulo c = new Circulo { raio = 3 };

        r.mostrarTipo();
        Console.WriteLine($"Área do retângulo: {r.calcularArea()}");

        c.mostrarTipo();
        Console.WriteLine($"Área do circulo: {c.calcularArea()}");
    }
}
