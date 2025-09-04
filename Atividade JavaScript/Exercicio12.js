let ladoA = prompt("Digite o primeiro lado do triângulo");
let ladoB = prompt("Digite o segundo lado do triângulo");
let ladoC = prompt("Digite o terceiro lado do triângulo");

if(ladoA == ladoB && ladoA == ladoC)
{
    console.log("O triangulo é Equilatero")
}
else if(ladoA == ladoB | ladoA == ladoC | ladoB == ladoC)
{
    console.log("O triangulo é Isóceles");
}
else if(ladoA != ladoB && ladoA != ladoC && ladoB != ladoC)
{
    console.log("O triangulo é Escaleno")
}