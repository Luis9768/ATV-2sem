namespace Introducao_C_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo(a) ao sistema.");

        /*// Entrada de Dados
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nOlá, {nome}! Você tem {idade} anos.");

        if (idade < 18)
        {
            Console.WriteLine("Você ainda é menor de idade.");
        }
        else
        {
            Console.WriteLine("Você já é maior de idade");
        }
        */

        // Menu
        Console.WriteLine("\nEscolha uma opção: ");
        Console.WriteLine("1 - Ver a tabuada de um número: ");
        Console.WriteLine("2 - Contar até um número: ");
        Console.WriteLine("3 fibonnaci");
        Console.WriteLine("4 - Sair");
        Console.Write("Digite a sua opção: ");

        int opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Digite o numero que você2 quer ver a tabuada: ");
                int number = int.Parse(Console.ReadLine());

                for (int i = 0; i <= 10; i++)
                {
                    int result = i * number;
                    Console.WriteLine($"{number} x {i} = {result}");
                }
                break;
            case 2:
                Console.WriteLine("Escolha o número: ");
                int cont = int.Parse(Console.ReadLine());

                for (int i = 0; i <= cont; i++)
                {
                    Console.WriteLine(i);
                }
                break;
            case 3:
                Console.WriteLine("selecione a quantidade de numeros: ");
                int leitor = int.Parse(Console.ReadLine());

                int a = 0;
                int b = 1;
                Console.WriteLine("Sequência de Fibonacci:");
                Console.Write(a + " " + b + " ");

                for (int i = 1; i < leitor; i++)
                {
                    int c = a + b;
                    Console.Write(c + " ");
                    a = b;
                    b = c;
                }
                break;



        }
    }
}


