using static System.Console;
int code;
double quantia;
WriteLine("tabela de preços" +
    "\n100   Cachorro quente:  R$1,70" +
    "\n101   Bauru simples:    R$2,30" +
    "\n102   Bauru com ovo:    R$2.60" +
    "\n103   Hamburguer:       R$2.40" +
    "\n104   Cheeseburguer:    R$2.50" +
    "\n105   Refrigerante:     R$1.00");
WriteLine("\ndigite o código do seu pedido e a quantidade:");
code = Convert.ToInt32(ReadLine());
quantia = Convert.ToDouble(ReadLine());
switch (code)
{
    case 100:
        WriteLine("O valor do seu pedido de cachorro quente em reais é de: R$" + 1.70 * quantia); break;
    case 101:
        WriteLine("O valor do seu pedido de bauru simples em reais é de: R$" + 2.30 * quantia); break;
    case 102:
        WriteLine("O valor do seu pedido de bauru com ovo em reais é de: R$" + 2.60 * quantia); break;
    case 103:
        WriteLine("O valor do seu pedido de hamburguer em reais é de: R$" + 2.40 * quantia); break;
    case 104:
        WriteLine("O valor do seu pedido de cheeseburguer em reais é de: R$" + 2.50 * quantia); break;
    case 105:
        WriteLine("O valor do seu pedido de refrigerante em reais é de: R$" + 1.00 * quantia); break;
    default:
        WriteLine("Insira um código de produto valido."); break;
}
WriteLine("Bom lanche!");