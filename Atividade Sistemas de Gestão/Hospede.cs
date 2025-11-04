using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_Sistemas_de_Gestão
{
    public class Hospede
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        // Método construtor
        public Hospede(string NomeConstrutor, string CpfConstrutor, string TelefoneConstrutor)
        {
            Nome = NomeConstrutor;
            Cpf = CpfConstrutor;
            Telefone = TelefoneConstrutor;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Dados do hóspede: Nome - {Nome}, CPF - {Cpf}, - Telefone: {Telefone}");
        }
    }
    
}