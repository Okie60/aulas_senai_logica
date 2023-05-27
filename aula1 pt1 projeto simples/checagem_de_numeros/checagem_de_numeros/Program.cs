using static System.Console;
double num1, num2;
WriteLine("Digite dois números:");
num1 = Convert.ToDouble(ReadLine());
num2 = Convert.ToDouble(ReadLine());
if (num1 > num2)
{
    WriteLine($"O número {num1} é maior que {num2}");
}
else if (num1 < num2)
{
    WriteLine($"O número {num2} é maior que {num1}");
}
else
{
    WriteLine("São números iguais");
}
