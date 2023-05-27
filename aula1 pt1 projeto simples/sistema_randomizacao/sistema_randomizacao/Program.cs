using static System.Console;
using System;

class Program
{
    static void Main()
    {
        double num;
        Random rnd = new Random(Environment.TickCount);

        Console.WriteLine("Escolha um número entre 1 e 10");
        num = Convert.ToDouble(Console.ReadLine());

        if (num >= 1 && num <= 10)
        {
            var randomNumber = rnd.Next(1, 11);

            if (num == randomNumber)
            {
                Console.WriteLine("Você acertou!");
            }
            else
            {
                Console.WriteLine("Que pena, você errou :(");
            }
        }
        else
        {
            Console.WriteLine("Escolha um número entre 1 e 10!");
        }
    }
}
