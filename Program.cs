using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" + $"Preço: {venda.Preço}, Data: {venda.DataVenda.ToString("dd/MM/yyy HH:mm")}");
}

