/*-----------------CALCULADORA----------------------*/
let number1 = prompt("Digite o primeiro número.")
let number2 = prompt("Digite o segundo número.")
let operacao = prompt("Insira a operacao")

number1 = parseInt(number1)
number2 = parseInt(number2)

if(operacao == "+")
{alert("Resultado = "+ (number1 + number2));
}
else if(operacao == "-")
{alert("Resultado = "+ (number1 - number2));
}
else if(operacao == "*")
{alert("Resultado = "+ (number1 * number2));
}
else if(operacao == "/")
{alert("Resultado = "+ (number1 / number2));
}
