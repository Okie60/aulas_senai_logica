using static System.Console;
int idade;
WriteLine("Insira sua idade:");
idade = Convert.ToInt32(ReadLine());
if (idade >= 18 && idade <= 67)
{
    WriteLine("Você está dentro da idade permitida para doação de sangue.");
}
else
{
    WriteLine("Você não tem a idade permitida para doação de sangue");
}
