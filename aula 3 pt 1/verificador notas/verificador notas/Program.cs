using static System.Console;
double nota1, nota2, media;
WriteLine("Digite suas duas notas:");
nota1 = Convert.ToDouble(ReadLine());
nota2 = Convert.ToDouble(ReadLine());
media = Convert.ToDouble((nota1 + nota2) / 2);
if (media >= 70 && media <= 99)
{
    WriteLine("Parabéns, você foi aprovado.");
}
else if (media == 100)
{
    WriteLine("Parabéns, aprovado com perfeição.");
}
else
{
    WriteLine("reprovado");
}