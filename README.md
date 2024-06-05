# Arquivo-Json

Este código em C# contém duas partes distintas: a definição da classe `Venda` e o uso dessa classe para criar uma instância, serializá-la em formato JSON e escrevê-la em um arquivo. Vamos documentar cada parte do código:

### Definição da Classe `Venda`
```csharp
namespace Models
{
    public class Venda
    {
        // Construtor da classe Venda para inicializar suas propriedades
        public Venda(int id, string produto, decimal preco)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
        }
        
        // Propriedade ID da venda
        public int Id { get; set; }
        
        // Propriedade Produto da venda
        public string Produto { get; set; }
        
        // Propriedade Preço da venda
        public decimal Preco { get; set; }
    }
}
```
Esta seção define uma classe chamada `Venda` no namespace `Models`. A classe possui três propriedades: `Id`, `Produto` e `Preco`, que representam o identificador, o produto e o preço da venda, respectivamente. Além disso, há um construtor que inicializa essas propriedades com os valores passados como parâmetros.

### Uso da Classe `Venda` para Serialização e Gravação em Arquivo
```csharp
using System.Globalization;
using Models;
using Newtonsoft.Json;

// Cria uma instância da classe Venda com valores específicos
Venda v1 = new Venda(1, "Material de escritorio", 25.00M);

// Serializa o objeto v1 em formato JSON com formatação indentada
string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

// Escreve o conteúdo serializado em um arquivo chamado vendas.json
System.IO.File.WriteAllText("Arquivos/vendas.json", serializado);

// Exibe o conteúdo serializado no console
Console.WriteLine(serializado);
```
Nesta parte do código, após definir a classe `Venda`, são realizadas as seguintes ações:

1. Uma instância da classe `Venda` é criada com valores específicos.
2. O objeto `v1` é serializado em formato JSON com formatação indentada usando a biblioteca Newtonsoft.Json.
3. O conteúdo serializado é gravado em um arquivo chamado `vendas.json` no diretório especificado.
4. O conteúdo serializado é exibido no console.

Essas ações demonstram o processo de criação, manipulação e persistência de objetos da classe `Venda` em formato JSON.
