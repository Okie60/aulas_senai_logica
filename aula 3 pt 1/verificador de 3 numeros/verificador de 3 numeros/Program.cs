using static System.Console;
double numA, numB, numC;
WriteLine("Escreva 3 números:");
numA = Convert.ToDouble(ReadLine());
numB = Convert.ToDouble(ReadLine());
numC = Convert.ToDouble(ReadLine());
if (numA > numB && numA > numC)
{
    WriteLine($"O número {numA} é maior que {numB} e {numC}.");
}
else if (numB > numA && numB > numC)
{
    WriteLine($"O número {numB} é maior que {numA} e {numC}.");
}
else if (numC > numA && numC > numA)
{
    WriteLine($"O número {numC} é maior que {numA} e {numB}.");
}
else
{
    WriteLine("Ambos são iguais.");
}