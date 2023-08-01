using static System.Console;
List<string> alunos = new List<string>();
List<double> notas1 = new List<double>();
List<double> notas2 = new List<double>();
List<double> media = new List<double>();
int numero_alunos, numero_notas = 0;
WriteLine("Escreva o número de alunos:");
numero_alunos = Convert.ToInt32(ReadLine());
for (int i = 0; i < numero_alunos; i++)
{
    WriteLine($"Aluno {i + 1}:");
    alunos.Add(ReadLine());
}
for (int c = 0; c < numero_alunos; c++)
{
    WriteLine($"Nota 1 e 2 do aluno {c + 1}");
    notas1.Add(Convert.ToDouble(ReadLine()));
    notas2.Add(Convert.ToDouble(ReadLine()));
    media.Add((notas1[numero_notas] + notas2[numero_notas]) / 2);
    numero_notas++;
}
numero_notas = 0;
foreach (var item in alunos)
{
    WriteLine($"Aluno: {item} -- 1° Nota: {notas1[numero_notas]} -- 2° Nota: {notas2[numero_notas]} -- Média: {media[numero_notas]}");
    numero_notas++;
}