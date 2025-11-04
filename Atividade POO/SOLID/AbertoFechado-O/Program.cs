namespace AbertoFechado_O;

class Program
{
    static void Main(string[] args)
    {
        Desconto d1 = new DescontoNatal();
        Desconto d2 = new DescontoBlackFriday();

        //:C traz o formato monetario do Sistema
        Console.WriteLine($"Natal: {d1.calcular(1000):C}");
        Console.WriteLine($"Black Friday: {d2.calcular(1000):C}");
        Console.WriteLine($"Black Friday: {d2.calcular(2000)}");
    }
}
