using static System.Console;

List<int> numberList = new List<int>();//O /new List<int>()\ instancia/Cria um objeto.
for (int i = 0; i < 3; i++)
{
    WriteLine($"Digite o número {i + 1}");
    numberList.Add(Convert.ToInt32(ReadLine()));
}
WriteLine("\n");
foreach (int i in numberList)
{
    WriteLine(i);
}
WriteLine("\nNúmero da posição 1 da lista é: " + numberList[1]);

WriteLine("\nContagem de registros da Lista é: " + numberList.Count);
WriteLine("\nCapacidade de registros da Lista é: " + numberList.Capacity);

WriteLine("\nInserir número 100 na posição 2:");
numberList.Insert(2, 100);
foreach (var n in numberList)
{
    WriteLine(n);
}

WriteLine("\nRemover número 100 na posição 2:");
numberList.Remove(100);
numberList.RemoveAt(2);
foreach (var n in numberList)
{
    WriteLine(n);
}

WriteLine("\nPesquise um número na lista:");
WriteLine("\nDigite um número:");
int num = Convert.ToInt32(ReadLine());
int num2 = numberList.IndexOf(num);
if (num2 >= 0)
{
    WriteLine($"Número encontrado na posição {num2}");
}
else
{
    WriteLine("Não existe esse número na lista.");
}