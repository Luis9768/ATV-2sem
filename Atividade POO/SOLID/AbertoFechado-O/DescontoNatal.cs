namespace AbertoFechado_O
{
    public class DescontoNatal : Desconto
    {
        public override double calcular(double valor) => valor * 0.10;
    }
}