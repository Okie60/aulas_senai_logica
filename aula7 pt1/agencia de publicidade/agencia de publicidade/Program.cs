using static System.Console;
List<string> modelos = new List<string>();
List<int> idades = new List<int>();
WriteLine("Digite as 20 candidatas, e suas respectivas idades:");
for (int i = 0; i < 20; i++)
{
    WriteLine($"Modelo {i + 1}, Idade {i + 1}:");
    modelos.Add(ReadLine());
    idades.Add(Convert.ToInt32(ReadLine()));
}
int local_modelos = 0;
foreach (int item in idades)
{
    if (item >= 18 || item <= 20)
    {
        WriteLine($"Modelo apta a concorrer a vaga: {modelos[local_modelos]} - Idade: {item}");
    }
    else
    {
        WriteLine($"Modelo não apta a concorrer a vaga: {modelos[local_modelos]} - Idade: {item}");
    }
    local_modelos++;
}