using static System.Console;
double num1, num2, leftov;
WriteLine("Insira 1 número inteiro para determinar se ele é par ou não:");
num1 = Convert.ToDouble(ReadLine());
if (num1 % 2 == 0)
{
    WriteLine($"O número {num1} é par");
}
else
{
    WriteLine($"O número {num1} é ímpar");
}
