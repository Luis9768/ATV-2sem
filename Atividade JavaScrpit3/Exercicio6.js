const alunos =
    [{ nome: "Ana", nota: 8 },
    { nome: "Carlos", nota: 5 },
    { nome: "Beatriz", nota: 9 }];
const maiorNota = alunos.find(nota => nota.nota >= 7);
console.log(maiorNota);