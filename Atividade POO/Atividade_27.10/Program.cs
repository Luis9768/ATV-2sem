namespace Atividade_27._10;

class Program
{
    static void Main(string[] args)
    {/*
        //SEM CONSTRUTOR
        Livro novoLivro = new Livro();// SEM PARAMETROS

        Console.WriteLine($"Titulo{novoLivro.titulo}");
        Console.WriteLine($"Ano: {novoLivro.anoPublicacao}");
        Console.WriteLine($"Disponivel: {novoLivro.estaDisponivel}");

        //colocando valores manualmente
        novoLivro.titulo = "O Poder do Construtor";
        novoLivro.autor = "Miguel de Servantes";
        novoLivro.anoPublicacao = 1950;
        novoLivro.preco = 60.45;
        novoLivro.estaDisponivel = true;

        Console.WriteLine("Exibindo detalhes");
        novoLivro.exibirDetalhes
        */
        Console.WriteLine(">>>>>Sistema de controle de biblioteca<<<<<\n");
        Livro livro1 = new Livro("A arte da Guerra", "Sun Tzu", 1950, 85.30);
        Livro livro2 = new Livro("Dom Casmurro", "Machado de Assis", 1899, 60.20);

        Console.WriteLine("Interagindo com o livro 1");
        livro1.exibirDetalhes();
        livro1.emprestar();
        livro1.exibirDetalhes();
        livro1.emprestar();

        Console.WriteLine("Interagindo com o livro 2");
        livro2.exibirDetalhes();
        livro2.preco = 32.99;
        Console.WriteLine($"Atualização de preço: {livro2.titulo} ajustado para R${livro2.preco:F2}");
        livro2.exibirDetalhes();


    }
}
