using static System.Console;
List<string> nomes = new List<string>();
List<int> idades = new List<int>();
WriteLine("Digite o nome e a idade dos 10 alunos:");
for (int i = 0; i < 10; i++)
{
    WriteLine($"Aluno {i + 1} + Idade {i + 1}:");
    nomes.Add(ReadLine());
    idades.Add(Convert.ToInt32(ReadLine()));
}
List<int> sortedIndexes = new List<int>();
for (int i = 0; i < nomes.Count; i++)
{
    sortedIndexes.Add(i);
}
sortedIndexes.Sort((x, y) => nomes[x].CompareTo(nomes[y]));
foreach (int index in sortedIndexes)
{
    WriteLine($"Aluno {nomes[index]} -- Idade {idades[index]}");
}
//Tenho que terminar