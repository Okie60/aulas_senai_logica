using static System.Console;
string mon1, mon2, mon3, mon4, mon5, mon6, mon7, mon8, mon9, mon10, mon11, mon12;
mon1 = "Janeiro"; mon2 = "feveriro"; mon3 = "março"; mon4 = "abril"; mon5 = "maio"; mon6 = "junho";
mon7 = "julho"; mon8 = "agosto"; mon9 = "setembro"; mon10 = "outubro"; mon11 = "novembro"; mon12 = "dezembro";
int mes;
WriteLine("Digite um número de 0 a 9 ou (n,d) para identificar um mês:");
mes = Convert.ToInt32(ReadLine());
switch (mes)
{
    case 1:
        WriteLine($"Mês de {mon1}"); break;
    case 2:
        WriteLine($"Mês de {mon2}"); break;
    case 3:
        WriteLine($"Mês de {mon3}"); break;
    case 4:
        WriteLine($"Mês de {mon4}"); break;
    case 5:
        WriteLine($"Mês de {mon5}"); break;
    case 6:
        WriteLine($"Mês de {mon6}"); break;
    case 7:
        WriteLine($"Mês de {mon7}"); break;
    case 8:
        WriteLine($"Mês de {mon8}"); break;
    case 9:
        WriteLine($"Mês de {mon9}"); break;
    case 10:
        WriteLine($"Mês de {mon10}"); break;
    case 11:
        WriteLine($"Mês de {mon11}"); break;
    case 12:
        WriteLine($"Mês de {mon12}"); break;
    default:
        WriteLine("insira um mês valido"); break;
}