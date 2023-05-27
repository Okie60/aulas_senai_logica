using static System.Console;
string nome;
double nota1, nota2, nota3, nota4, media;
WriteLine("insira seu nome:");
nome = ReadLine();
WriteLine("insira suas quatro notas");
nota1 = Convert.ToDouble(ReadLine());
nota2 = Convert.ToDouble(ReadLine());
nota3 = Convert.ToDouble(ReadLine());
nota4 = Convert.ToDouble(ReadLine());
media = (nota1 + nota2 + nota3 + nota4) / 4;
if (media >= 6)
{
    WriteLine($"Parabéns você foi aprovado! Sua média é de {media}");
}
else
{
    WriteLine($"Que pena você foi reprovado. Sua média é de {media}");
}
