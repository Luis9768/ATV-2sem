using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_27._10
{
    public class Livro
    {
        public string titulo { get; set; }
        public int autor { get; set; }
        public int anoPublicacao { get; set; }
       /* {
            get
            {
                return anoPublicacao;
            }
            set
            {
                if (value > 0)
                {
                    anoPublicacao = value;
                }
                else
                {
                    Console.WriteLine("Erro! Ano de publicacao é inválido!");
                }
            }*/
        
        public double preco { get; set; }
        public bool estaDisponivel { get; set; } = true;

        //Construtor
        //é um metodo especial, usado para inicializar o estado do objeto
        public Livro(string tituloConstrutuor, string autorConstrutor, int anoConstrutor, double precoConstrutor)
        {
            titulo = tituloConstrutuor;
            autor = anoConstrutor;
            anoPublicacao = anoConstrutor;
            preco = precoConstrutor;
            //Esta disponivel comeca como true
            estaDisponivel = true;
            Console.WriteLine($"Novo livro: {tituloConstrutuor} criado e dísponivel");
        }

        public void exibirDetalhes()
        {
            Console.WriteLine("Detalhes do Livro");
            Console.WriteLine($"Titulo: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Publicação: {anoPublicacao}");
            Console.WriteLine($"Preço: {preco:F2}");//FORMATA COM DUAS CASAS DECIMAIS

            if (estaDisponivel) { Console.WriteLine("Status: Disponivel para emprestimo"); }
            else { Console.WriteLine("Status: Emprestado! (Indisponivel)"); }
        }
        public void emprestar(){
            if (estaDisponivel)
            {
                estaDisponivel = false;
                Console.WriteLine($"O livro {titulo} foi emprestado");
            }
            else
            {
                Console.WriteLine($"O livro: {titulo} já foi emprestado");
            }
        }
    }
}