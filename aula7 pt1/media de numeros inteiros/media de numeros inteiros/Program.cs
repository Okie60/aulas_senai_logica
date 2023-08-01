using static System.Console;
List<int> numeros = new List<int>();
double n_Numeros, total_numeros = 0;
double media;
WriteLine("Escreva o número de Números:");
n_Numeros = Convert.ToInt32(ReadLine());
for (int i = 0; i < n_Numeros; i++)
{
    WriteLine($"Número {i + 1}:");
    numeros.Add(Convert.ToInt32(ReadLine()));
}
foreach (int i in numeros)
{
    total_numeros += i;
}
media = total_numeros / n_Numeros;
numeros.Sort();
WriteLine($"Média: {media} -- Maior número: {numeros.Last()}");