using static System.Console;
List<int> numeros = new List<int>();
List<int> n_pares = new List<int>();
List<int> n_impares = new List<int>();
WriteLine("Escreva o 10 números inteiros maiores que 0:");
for (int i = 0; i < 4; i++)
{
    WriteLine($"Número {i + 1}:");
    int numero = Convert.ToInt32(ReadLine());
    if (numero <= 0)
    {
        WriteLine("Escreva apenas números inteiros maiores que 0.");
        break;
    }
    numeros.Add(numero);
    if (numero % 2 == 0)
    {
        n_pares.Add(numero);
    }
    else
    {
        n_impares.Add(numero);
    }
}
numeros.Sort(); n_pares.Sort(); n_impares.Sort();
for (int i = 0; i < numeros.Count; i++)
{
    int numero = numeros[i];
    int par = (i < n_pares.Count) ? n_pares[i] : 0;
    int impar = (i < n_impares.Count) ? n_impares[i] : 0;

    WriteLine($"Número inserido: {numero} || Número par: {par} || Número ímpar: {impar}");
}