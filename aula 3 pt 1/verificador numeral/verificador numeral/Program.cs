using static System.Console;
double numA, numB;
WriteLine("Escreva 2 números:");
numA = Convert.ToDouble(ReadLine());
numB = Convert.ToDouble(ReadLine());
if (numA > numB)
{
    WriteLine($"O número {numA} é maior que {numB}.");
}
else if (numB > numA)
{
    WriteLine($"O número {numB} é maior que {numA}.");
}
else
{
    WriteLine("Ambos são iguais.");
}