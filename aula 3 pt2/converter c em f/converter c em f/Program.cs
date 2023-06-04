using static System.Console;
double C, F;
WriteLine("Insira a temperatura atual, em graus celsius:");
C = Convert.ToDouble(ReadLine());
F = Convert.ToDouble((C * 1.8) + 32);
WriteLine($"temperatura em Celsius: {C};\nTemperatura em Fahrenheit: {F}");