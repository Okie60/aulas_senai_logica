using static System.Console;
namespace uaulegal
{
    class Idade
    {
        static int Calculo(int n1)
        {
            return n1;
            //return DateTime.Today.Year - n1;
        }
        static void Main(string[] args)
        {
            WriteLine("Digite sua data de nascimento:");
            int n1 = Convert.ToInt32(ReadLine());
            int anoAtual = DateTime.Today.Year;

            WriteLine($"Sua idade é: " + Calculo(anoAtual - n1));
        }
    }
}