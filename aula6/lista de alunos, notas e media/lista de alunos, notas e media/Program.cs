using static System.Console;
List<string> nomes = new List<string>();
List<int> notas = new List<int>();
WriteLine("Escreva os nomes e as notas de todos os 10 alunos: ");
for (int n = 0; n < 10; n++)
{
    WriteLine($"Insira o Nome do aluno {n} e a sua nota:");
    nomes.Add(ReadLine());
    notas.Add(Convert.ToInt32(ReadLine()));
}
/*WriteLine("\nNomes dos alunos: ");
foreach (string n in nomes)
{
    WriteLine(n);
}
WriteLine("\nNotas alunos");
foreach (int i in notas)
{
    WriteLine(i);
}*/
double totalNotas = 0; //= notas[0] + notas[1] + notas[2] + notas[3] + notas[4] + notas[5] + notas[6] + notas[7] + notas[8] + notas[9]; fiz de uma forma burra
int localNota = 0;
foreach (int item in notas)
{
    totalNotas += item;
}

foreach (string aluno in nomes)
{
    WriteLine($"Aluno: {aluno} - Nota: {notas[localNota]}");
    localNota++;
}
WriteLine($"\nMédia = {totalNotas / nomes.Count}");