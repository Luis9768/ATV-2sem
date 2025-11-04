namespace Atividade2_ClasseAbstrata
{
    public class Retangulo : Forma
    {
        public double largura;
        public double altura;
        public override double calcularArea() => largura * altura;
    }
}