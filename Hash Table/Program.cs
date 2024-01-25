// A classe Dictionary representa uma coleção de chaves e valores.
// É a implementação mais próxima que temos no C# da estrutura de dados Tabela Hash

Dictionary<string, string> AgendaTelefonica = new Dictionary<string, string>();

AgendaTelefonica.Add("Marcelo Matias", "(84) 3006-4305");
AgendaTelefonica.Add("João Gustavo", "(14) 3248-5334");
AgendaTelefonica.Add("Luis Henrique", "(47) 3836-8149");
AgendaTelefonica.Add("Carlos Eduardo", "(77) 2284-5318");

foreach (KeyValuePair<string, string> kvp in AgendaTelefonica)
{
    Console.WriteLine($"Nome: {kvp.Key} \t Número: {kvp.Value}");
}

Console.WriteLine("\nTentando adicionar uma chave que já existe na Tabela Hash");
try 
{
    AgendaTelefonica.Add("Luis Henrique", "(49) 2387-3857");
}
catch (ArgumentException)
{
    Console.WriteLine("Já existe um contato salvo com a chave \"Luis Henrique\"");
}

Console.WriteLine($"\nRemovendo o valor {AgendaTelefonica["Marcelo Matias"]} da Tabela Hash após conferir se este valor existe");

if(!AgendaTelefonica.ContainsKey("Marcelo Matias")) 
{
    Console.WriteLine("Chave informada não existe na tabela");
}
else 
{ 
    AgendaTelefonica.Remove("Marcelo Matias");
    Console.WriteLine("Valor removido com sucesso");
}

Console.WriteLine("\nMostrando novamente a lista telefônica:");
foreach(KeyValuePair <string, string> kvp in AgendaTelefonica) {
    Console.WriteLine($"Nome: {kvp.Key} \t Número: {kvp.Value}");
}