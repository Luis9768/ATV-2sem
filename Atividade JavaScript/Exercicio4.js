/*----------------VERIFICADOR SE O NUMERO É POSITIVO OU NEGATIVO-----------------*/
let number = prompt("Digite o número para verificação");
if(number > 0){
    console.log("O número digitado " + (number) + " é positivo.")
}
else if(number == 0)
{
    console.log("O número selecionado é " + number);
}
else{
    console.log("O número digitado " +(number)+ " -é negativo")
}