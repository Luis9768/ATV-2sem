namespace Atividade_POO
{
    public class Pessoa
    {
        public String name;
        public int idade;
        //virtual - vamos utilizar o metodo em outra classe, podendo sobresescrever
        public virtual void apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {name} e tenho {idade} anos de idade.");
        }
    }

}