using static System.Console;
List<int> V1 = new List<int>();
List<int> V2 = new List<int>();
WriteLine("Digite 40 números:");
for (int i = 0; i < 20; i++)
{
    WriteLine($"{i + 1}° número:");
    V1.Add(Convert.ToInt32(ReadLine()));
    V2.Add(Convert.ToInt32(ReadLine()));
}
int local_numeros = 0;
foreach (int item in V1)
{
    if (item == V2[local_numeros])
    {
        WriteLine($"Números iguais: {item} / {V2[local_numeros]}");
    }
    else
    {
        WriteLine("Não há números iguais.");
    }
    local_numeros++;
}