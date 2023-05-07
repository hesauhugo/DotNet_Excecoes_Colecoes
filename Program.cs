using DotNet_Excecoes_Colecoes.Models;

//Incluindo valores
Console.WriteLine("Incluindo valores");
Dictionary<string,string> estados = new Dictionary<string,string>();

estados.Add("SP","São Paulo");
estados.Add("BA","Bahia");
estados.Add("MG","Minas Gerais");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
Console.WriteLine("==========================================");
// Removendo valores
Console.WriteLine($"Removendo BA");
estados.Remove("BA");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("==========================================");

// Alterando valores
Console.WriteLine($"Alterando valores SP - São Paulo");
estados["SP"] = "SP - São Paulo";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("==========================================");
var chave = "SP";
Console.WriteLine($"Verificando se contém a chave: {chave}");

if(estados.ContainsKey(chave)){
    Console.WriteLine($"Não é seguro incluir a chave: {chave}");
}else{
    Console.WriteLine($"É seguro incluir a chave: {chave}");
}