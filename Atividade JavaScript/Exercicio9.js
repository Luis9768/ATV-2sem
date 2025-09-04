/*----------VERIFICA SE O ANO É BISSEXTO------------*/
let ano = prompt("Digite o ano");
ano = parseInt(ano);

if(ano % 100 && !ano % 4 && !ano % 400 ){
    console.log("O ano "+ ano + " é bissexto");
}