/*-----------------------------10% DE DESCONTO NO VALOR DA COMPRAR SE EXCEDER 100 REAIS--------------*/
let cash = 100;
let valorCompra = prompt("Digite o valor da sua compra");
if (valorCompra >= cash) {
    console.log(valorCompra * 0.9 + "Sua compra ultrapassou o valor de 100 reais por isso toma 10% de desconto aproveite.")}
else {
    console.log(valorCompra)
}