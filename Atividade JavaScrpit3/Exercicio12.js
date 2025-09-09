const numeroContagem = [1, 2, 3, 4, 5];
const contagem = numeroContagem.reduce((acumulador,soma) => acumulador + soma, 0) / numeroContagem.length
console.log(contagem);