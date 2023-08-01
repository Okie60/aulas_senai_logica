using static System.Console;
List<double> temp_volt = new List<double>();
int n_voltas;
WriteLine("Escreva o número de voltas:");
n_voltas = Convert.ToInt32(ReadLine());

for (int i = 0; i < n_voltas; i++)
{
    WriteLine($"Tempo da volta {i + 1}:");
    temp_volt.Add(Convert.ToDouble(ReadLine()));
}
double menor_tempo = temp_volt.Min();
int vota_menor_tempo = temp_volt.IndexOf(menor_tempo) + 1;

WriteLine($"Tempo da Melhor volta: {Convert.ToDouble(menor_tempo)} - Volta ao qual ocorreu: {vota_menor_tempo}");