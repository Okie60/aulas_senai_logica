using static System.Console;
List<string> names = new List<string>();
WriteLine("Escreva 10 nomes:");
for (int i = 0; i < 10; i++)
{
    names.Add((ReadLine()));
}
names.Sort();
WriteLine("\n");
foreach (string n in names)
{
    WriteLine(n);
}
WriteLine("\nPrimeiro nome: " + names[0]);
WriteLine("Ultimo nome: " + names[9]);