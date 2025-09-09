//FOR
//Contando de 1 até N
/*let n = parseInt(prompt("Digite um número: "));
for(let i = 1; i <= n; i++){console.log(i);}
for(let i = 1; i <= n; i--){console.log(i);}

let soma = 0;
let i = 1;*/

/*while(i<=10){
    soma = soma + i;
    console.log("O resultado é: " + soma)
    i++
}
console.log("A soma total dos 10 número é: " + soma)
*/
/*
let number = 1;
do{
    console.log("Numero: " + number)
    number++
}while (number<= 5);
*/

let numbers = [1,2,3,4,5];
numbers.forEach(function(number){console.log("Número: " + numbers)})

let frutas = ["maça", "banana", "uva", "pêra"]
frutas.forEach(function(fruta){console.log(frutas)})


for(let i = 0; i < numbers.length; i++){console.log("Numero: "+ numbers[i])}
for(let i = 0; i < frutas.length; i++){console.log("Objetos: "+ frutas[i])}