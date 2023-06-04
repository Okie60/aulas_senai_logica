using static System.Console;
double MPS, KPH;
WriteLine("Insira a velocidade, em m/s:");
MPS = Convert.ToDouble(ReadLine());
KPH = Convert.ToDouble(MPS * 3.6);
WriteLine($"Velocidade em m/s: {MPS};\nVelocidade em Km/h: {KPH}");
