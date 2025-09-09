/*----------VERIFICA SE O ANO É BISSEXTO------------*/
let ano = prompt("Digite o ano");
ano = parseInt(ano);
let resultado;
((!Boolean(ano %4) && Boolean(ano % 100)) || Boolean (ano % 400))
? resultado = "é bissexto"
: resultado = "não é bissexto"
console.log("a ano "+ano+resultado)