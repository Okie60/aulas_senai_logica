using static System.Console;
int val1, val2, vals;
WriteLine("Insira 2 números");
val1 = Convert.ToInt32(ReadLine());
val2 = Convert.ToInt32(ReadLine());
if (val1 > val2)
{
    WriteLine("Aqui está a sua sequência númérica:");
    for (int i = val1; i >= val2; i--)
    {
        WriteLine(i.ToString());
    }
}
else if (val1 < val2)
{
    WriteLine("Aqui está a sua sequência númérica:");
    for (int i = val1; i <= val2; i++)
    {
        WriteLine(i.ToString());
    }
}
else
{
    WriteLine("Os números são iguais.");
}