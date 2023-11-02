// ----- Tipos Nulos------

bool? desejaReceberEmail = null;

if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuário optou por receber email" );
}
else
{
    Console.WriteLine("O usuário não respondeu ou optou por não receber email");
}


// ----- Tipos Anonimo ------

var tipoAnonimo = new {Nome = "Tiago", Sobrenome = "Sabath", Altura = "1.80"};

Console.WriteLine("Nome: " + tipoAnonimo.Nome);
Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
Console.WriteLine("Altura: " + tipoAnonimo.Altura);


// ----- Tipos Anonimo em Coleção ------

using ExemplosTiposEspecias.Models;
using Newtonsoft.Json;

string conteudoAquivo = File.ReadAllText("Arquivos/venda.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoAquivo);

var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco});

foreach (var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
}


// ----- Tipos Dinâmico ------

dynamic variavelDinamica = 4;

Console.WriteLine($"tipo da variaveç: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = "Texto";
Console.WriteLine($"tipo da variaveç: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = true;
Console.WriteLine($"tipo da variaveç: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");


// ----- Tipos Classe Genéricas ------

using ExemplosTiposEspecias.Models;

MeuArray<int> arrayinterior = new MeuArray<int>();

arrayinterior.AdicionalElementoArray(30);

Console.WriteLine(arrayinterior[0]);



MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionalElementoArray("Teste");

Console.WriteLine(arrayString[0]);