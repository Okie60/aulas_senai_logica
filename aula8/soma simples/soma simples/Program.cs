using static System.Console;
namespace uaulegal
{
    class soma
    {
        static double Soma(double n1, double n2)
        {
            return (n1 + n2);
        }
        static void Main(string[] args)
        {
            WriteLine("Digite dois números para realizar uma soma:");
            double n1 = Convert.ToDouble(ReadLine());
            double n2 = Convert.ToDouble(ReadLine());
            WriteLine($"A soma entre {n1} + {n2} é: " + Soma(n1, n2));
        }
    }
}