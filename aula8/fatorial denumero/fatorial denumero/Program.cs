using static System.Console;
namespace uaulegal
{
    class manipuNumber
    {
        public int fatorial(int number)
        {
            int resultado;
            if (number == 1)
            {
                return 1;
            }
            else
            {
                resultado = fatorial(number - 1) * number;
                return resultado;
            }
        }

        static void Main(String[] args)
        {
            manipuNumber n = new manipuNumber();
            WriteLine("Digite um número inteiro");
            int num = Convert.ToInt32(ReadLine());
            WriteLine($"O fatorial do número digitado é: " + n.fatorial(num));
        }
    }
}