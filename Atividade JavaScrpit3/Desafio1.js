const livros = [
  { titulo: "Dom Casmurro", paginas: 300 },
  { titulo: "O Hobbit", paginas: 295 },
  { titulo: "A Revolução dos Bichos", paginas: 112 }
];
//livros com mais de 200 páginas
const paginasSoma = livros.filter(livro => livro.paginas >= 200);
paginasSoma.forEach(livro => {
  console.log(`- ${livro.titulo} (${livro.paginas} páginas)`);
});
