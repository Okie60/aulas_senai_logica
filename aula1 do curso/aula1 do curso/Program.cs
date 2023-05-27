/*
string poema_maneirao = "Batatinha quando nasce se esparrama pelo chão, legal e maneirão";
Console.WriteLine(poema_maneirao);
poema_maneirao = poema_maneirao.Replace("Batatinha", "Arroz doce");
Console.WriteLine(poema_maneirao);
Console.WriteLine(poema_maneirao.ToUpper());
Console.WriteLine(poema_maneirao.ToLower());
Console.WriteLine(poema_maneirao.Contains("Pão"));
*/
int num_A, num_B;
// operador;
Console.WriteLine("Insira um número para realizar o calcúlo: ");
num_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insira um operador para realizar o calcúlo: ");
//operador = Console.ReadLine();
Console.WriteLine("Insira um número para realizar o calcúlo: ");
num_B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("A soma dos números inseridos é: " + (num_A /*+ operador*/ + num_B));