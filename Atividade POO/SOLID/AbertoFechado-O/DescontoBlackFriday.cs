namespace AbertoFechado_O
{
    public class DescontoBlackFriday : Desconto
    {
        public override double calcular(double valor) => valor * 0.20;
    }
}