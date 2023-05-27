using static System.Console;
char opera;
double one, two, result;

WriteLine("Digite dois valores:");
one = Convert.ToDouble(ReadLine());
two = Convert.ToDouble(ReadLine());
WriteLine("Escolha seu operador:");
opera = (char)Read();

switch (opera)
{
    case '+':
        result = one + two;
        WriteLine($"o resultado foi: {result}"); break;
    case '-':
        result = one - two;
        WriteLine($"o resultado foi: {result}"); break;
    case '*':
        result = one * two;
        WriteLine($"o resultado foi: {result}"); break;
    case '/':
        result = one / two;
        WriteLine($"o resultado foi: {result}"); break;
    default:
        WriteLine("insira um operador válida"); break;
}