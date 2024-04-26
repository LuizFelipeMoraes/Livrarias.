
namespace Livrarias;
class Program
  //Aluno: Luiz Felipe Cola de Moraes
{
static void Main()
{
Livro livro1 = new Livro("Dom Quixote", " Miguel de Cervantes", "9788556510761", 138);
LivroDigital livroDigital1 = new LivroDigital("La Galatea", "Miguel de Cervantes", "9788556510761", 502, "PDF");

livro1.AdicionarEstoque(69);
livro1.Vender(102);

livroDigital1.AdicionarEstoque(32);
livroDigital1.Vender(401);

livro1.ImprimirEstadoEstoque();
livroDigital1.ImprimirEstadoEstoque();
}
}