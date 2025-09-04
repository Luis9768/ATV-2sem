/*-----------VERIFICA QUAL NUMERO É MAIOR---------------------*/
let number1 = prompt("Digite o primeiro número");
let number2 = prompt("Digite o segundo número");
let number3 = prompt(" Digite o terceiro número");

if(number1> number2 && number1>number3)
{
    console.log("O número 1 é maior")
}
else if(number2> number1 && number2>number3)
{
    console.log("O número 2 é maior")
}
else
{
    console.log("O número 3 é maior")
}