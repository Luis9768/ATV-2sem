/*------------- CRIANÇA, ADOLESCENTE OU ADULTO--------------- */
let idade = prompt("Digite sua idade aqui");
if (idade<=12){
    console.log("Você é uma criança.")
}
else if(idade>=13 && idade <= 17)
{
    console.log("Você é um adolescente.")
}
else{
    console.log("Você é um adulto");
}