
using System.Globalization;
using Models;
using Newtonsoft.Json;

Venda v1 = new Venda(1, "Material de escritorio", 25.00M);

string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);