/*let nome = "Luís";
let idade = 26;

console.log("Olá, meu nome é " + nome + ", tenho " + idade + "anos.");

let mensagem = 'Ola, meu nome é ${nome}';
//alert(mensagem)

console.log(typeof mensagem);//String
console.log(typeof idade);//number

let profissao;
console.log(typeof profissao)//undefined

let endereco = null;
console.log(typeof endereco);//object or null
*/

/*
//Estrutura condicional

//if / else
    let temperatura = 15;
    if (temperatura > 25)
    {
        console.log("Esta calor.");
    }
    else{
        console.log("Está frio.")
    }
    let nomeUsuario = prompt("Digita seu nome aqui parceiro embaixo");
    alert("Seu nome é: " + nomeUsuario);
    */

/*
//IF / IF ELSE / ELSE
let nota = parseInt(prompt("Digite a nota: "));

if  (nota > 6) {
    console.log("Aprovado(a)!")
}1
else if(nota >= 5){
    console.log("Está de recuperação!");
}
else{
    console.log("Está reprovado (a)!");
}
    */

//if ternario

let saldo = 90;
let podeComprar = saldo >= 100 ? "Compra aprovada" : "Tu ta comendo arroz com reboco de parede rapaz vai pra casa tu não tem dinheiro não";
console.log(podeComprar);


//Condicional Aninhada
//Multiplas verificações

let hora = 15;
let diaDaSemana = "Segunda";

//let semanal = hora >= 6 && hora < 12? "Bom dia Bruno" : "Já escureceu? ";
//console.log(semanal);

/*
if (hora >= 6 && hora < 12) {
    console.log("Bom dia!");
}
else {
    if (hora >= 12 && hora < 18) {
        if (diaDaSemana == "Segunda") {
            console.log("Boa tarde! Ótima semana!");
        }
        else {
            console.log("Boa tarde!")
        }
    }
    else {
        console.log("Boa noite");
    }
}
    */

let dia = 6;

switch (dia) {
    case 1:
        console.log("Domingo");
        break;
    case 2:
        console.log("Segunda");
        break;
    case 3:
        console.log("Terça");
        break;
    case 4:
        console.log("Quarta");
        break;
    case 5:
        console.log("Quinta");
        break;
    case 6:
        console.log("Sexta");
        break;
    case 7:
        console.log("Sábado");
        break;
    default:
        console.log("Dia Inválido.")
        break
}