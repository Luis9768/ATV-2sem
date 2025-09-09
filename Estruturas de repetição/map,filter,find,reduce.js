/*
FILTER


const numeros = [1,2,3,4,5,6];
const maioresQueDois = numeros.filter(numeros >= numeros >2);
console.log(maioresQueDois);



//filter names
/*
let names = ["Ana","Antonia","Joana","Epaminondas","Juarez"];
let longNames = names.filter(names => names.length > 5)
console.log(longNames);

//filter par number

let numbers = [1,2,3,4,5,6,7,8,9,10]
let evee = numbers.filter(numbers => numbers %2 === 0)


// filter object

let pessoas = [
    {nome: "Lucas", idade: 17},
    {nome: "Mariana", idade: 22},
    {nome: "Antonio", idade: 20}
    {nome: "João", idade: 2}
]
let adultos = pessoas.filter(pessoa=> pessoa.idade >= 18)
*/

//FIND
//RETORNA O PRIMEIRO ELEMENTO DA LISTA CORRESPONDENTE A CONDIÇÃO
/*
const produtos = [
    {id:1, nome: "Mouse", preco: 800},
    {id:2, nome: "Teclado", preco: 800},
    {id:3, nome: "Monitor", preco: 800}
]
const produtoCaro = produtos.find(produto => produto.preco > 600);
console.log(produtoCaro);
*/
/*
let numeros = [5,8,12,20,5,65];
let encontraado = numeros.find(numero>=numero>10);

//Buscar nome pela primeira letra

let nomes = ["Ana","Bruno","Carlos","Eva","Cátia"];

let nomeEncontrado = nomes.find(nome=>nome.startsWith("C"));
console.log(nomeEncontrado);
*/
//MAP
//MULTIPLICAR
/*
const numeros =[1,2,3,4,5]
const numerosDobrados = numeros.map(numero => numero *2)
console.log(numerosDobrados);
*/

//CRIANDO UM ARRAY APARTIR DE UM OBJETO
/*let pessoas = [
    {nome: "Lucas", idade: 17},
    {nome: "Mariana", idade: 22},
    {nome: "Antonio", idade: 20},
    {nome: "João", idade: 2}
];
let nomes = pessoas.map(pessoa => pessoa.nome);
console.log(nomes);
let mensagens = pessoas.map(pessoa => 
    `${pessoa.nome} tem ${pessoa.idade} anos.`
);
console.log(mensagens);
*/

//DEIXAR OS NOMES EM MAIUSCÚLO E DEIXAR EM SUFIXO
/*const nomes = ["ana","bruno","carla"];
const nomesMaiusculo = nomes.map(nome=>"Colaborador: "+ nome.toUpperCase())
console.log(nomesMaiusculo);
*/


//REDUCE
//REDUZ UM ARRAY A UM UNICO VALOR

//SOMAR TODOS OS NÚMEROS DO ARRAY
/*const numeros = [1,2,3,4,5];
const soma = numeros.reduce((acumulador,numero) => acumulador + numero, 0);
console.log(soma);
*/

//VERIFICAR MAIOR NUMERO DO ARRAY
/*
const numeros = [10,5,8,20,3];
const maiorNumero = numeros.reduce((max,numero)=>{
if(numero>max){return numero;}
else{return max;}
}, numeros[0]);
console.log(maiorNumero);
*/

//CONTAR FREQUENCIA DE PALAVRAS
/*
const palavras = ["maçã","banana","maçã", "laranja","banana","maçã"];
const contagem = palavras.reduce((acumulador,palavra) => {
    acumulador[palavra] = (acumulador[palavra]|| 0)+1;
    return acumulador
},{})
console.log(contagem);
*/
//MEDIA
/*
const notas = [7,8,9,6,10]
const media = notas.reduce((total,nota) => total+nota,0) / notas.length
console.log(media);
*/

//USO COMBINADO
const usuarios = [
    {id: 1, nome: "Alice", idade: 25},
    {id: 2, nome: "Bob", idade: 30},
    {id: 3, nome: "Carol", idade: 20}
]
//FILTRAR USUARIOS COM A IDADE MAIOR QUE 21
const maioresDeIdade = usuarios.filter(usuario => usuario.idade > 21);
//ENCONTRAR O PRIMEIRO USUÁRIO COM IDADE MAIOR QUE 21
const usuarioIdade = usuarios.find(usuario => usuario.idade > 21);
//CRIAR UM ARRAY PAENAS COM NOMES DE USUARIOS
const nomesUsuarios = usuarios.map(usuario => usuario.nome);
//Soma de todas as idades dos usuários usando o reduce
const somaIdades = usuarios.reduce((total,usuario) => total+usuario.id);

console.log("Maiores de idade: ", maioresDeIdade);
console.log("Primeiro maior de idade: ", usuarioIdade);
console.log("Nomes usuários: ", nomesUsuarios);
console.log("Soma de idades: ", somaIdades);