using static System.Console;
double produ1, produ2, produ3;
WriteLine("Insira o preço dos 3 produtos:");
produ1 = Convert.ToDouble(ReadLine());
produ2 = Convert.ToDouble(ReadLine());
produ3 = Convert.ToDouble(ReadLine());

if (produ1 < produ2 && produ1 < produ3)
{
    WriteLine($"Dentre os seguintes preços:\n{produ1}, {produ2}, {produ3}.\n{produ1} é o mais barato.");
}
else if (produ2 < produ1 && produ2 < produ3)
{
    WriteLine($"Dentre os seguintes preços:\n{produ1}, {produ2}, {produ3}.\n{produ2} é o mais barato.");
}
else if (produ3 < produ1 && produ3 < produ2)
{
    WriteLine($"Dentre os seguintes preços:\n{produ1}, {produ2}, {produ3}.\n{produ3} é o mais barato.");
}
else if (produ1 <= produ2)
{
    WriteLine($"Dentre os seguintes preços:\n{produ1}, {produ2}, {produ3}.\n{produ1} e {produ2}são os mais baratos.");
}
else if (produ1 <= produ3)
{
    WriteLine($"Dentre os seguintes preços:\n{produ1}, {produ2}, {produ3}.\n{produ1} e {produ3}são os mais baratos.");
}
else if (produ2 <= produ3)
{
    WriteLine($"Dentre os seguintes preços:\n{produ1}, {produ2}, {produ3}.\n{produ2} e {produ3}são os mais baratos.");
}
else
{
    WriteLine("todos os produtos têm o mesmo preço");
}