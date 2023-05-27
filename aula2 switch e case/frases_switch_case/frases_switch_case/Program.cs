using static System.Console;
string frase1, frase2, frase3;
frase1 = "legal e bacaninha";
frase2 = "maneirão";
frase3 = "uau, legal";
char optn;//abre a possíbilidade para operadores(pode ser usado para pedir que o usúario coloque um operador)
WriteLine("Escolha uma opção de 1 a 3");
optn = (char)Read();
switch (optn)// ótimo para otimização
{
    case '1'://case seria "em caso de", por exemplo, esse mesmo (em caso de o usúario digitar 1) e segue as ordens até o break, é tipo um if
        WriteLine(frase1);
        break;
    case '2':
        Write(frase2);
        break;
    case '3':
        WriteLine(frase3);
        break;
    default://só ocorre caso os cases sejam invalidos
        WriteLine("caracter invalido");
        break;
}
