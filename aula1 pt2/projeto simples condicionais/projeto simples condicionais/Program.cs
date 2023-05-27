using static System.Console;
double num1,num2;
WriteLine("escreva dois números:");
num1 = Convert.ToDouble(ReadLine());
num2 = Convert.ToDouble(ReadLine());
if (num1 > num2)
{
    WriteLine("o número " + num1 + " é maior que " + num2);
}
else if (num2 > num1)
{
    WriteLine("o número " + num2 + " é maior que " + num1);
}
else
{
    WriteLine("o número " + num1 + " é igual à " + num2);
}