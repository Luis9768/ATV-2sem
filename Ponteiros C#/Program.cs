namespace Ponteiros_C_;

class Program
{
    static unsafe void Main(string[] args)
    {
        int variavelA = 10;
        Console.WriteLine($"variavel: {variavelA}");

        //ponteiro = &endereço da variável
        int* ponteiro = &variavelA;
        Console.WriteLine($"Endereço memoria {(ulong)ponteiro}");

        //alterando o valor da variavelA manipulando um pedaço de memoria que ela ocupa
        *ponteiro = 75;
        Console.WriteLine($"variável: {variavelA}");

        
    }
}
