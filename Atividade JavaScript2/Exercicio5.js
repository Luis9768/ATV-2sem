let numeroAdivinhacao = parseInt(prompt("tente advinhar o número: "));
while(numeroAdivinhacao !=5){
    numeroAdivinhacao = Math.floor(Math.random() *100);
    if(numeroAdivinhacao != 5 ){
    console.log("Número gerado: "+numeroAdivinhacao);
    console.log("Você errou tente novamente!");}
    else{console.log("Você acertou!");}
}