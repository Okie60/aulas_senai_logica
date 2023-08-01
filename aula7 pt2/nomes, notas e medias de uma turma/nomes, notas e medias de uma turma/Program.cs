using static System.Console;
List<string> nomes = new List<string>();
List<int> notas = new List<int>();
double media, total_notas = 0;
WriteLine("Digite o nome de 10 estudantes, e suas respectivas notas:");
for (int i = 0; i < 10; i++)
{
    WriteLine($"Aluno {i + 1}, Idade {i + 1}:");
    nomes.Add(ReadLine());
    notas.Add(Convert.ToInt32(ReadLine()));
}
int local_notas = 0;
foreach (int item in notas)
{
    total_notas += item;
}
foreach (string aluno in nomes)
{
    WriteLine($"Aluno: {aluno} - Notas: {notas[local_notas]}");
    local_notas++;
}
media = total_notas / notas.Count;
WriteLine($"Media: {media}");