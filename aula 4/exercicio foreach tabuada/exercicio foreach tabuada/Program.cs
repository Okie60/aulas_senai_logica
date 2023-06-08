using static System.Console;
double num;
WriteLine("Digite um número para saber a sua tabuada do 0 ao 10");
num = Convert.ToDouble(ReadLine());
int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
foreach (int numeros in array)
{
    WriteLine($"{num} * {numeros}: " + numeros * num);
}