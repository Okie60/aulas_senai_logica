using static System.Console;
double soldCars, totalVal, normalSal, soldCarVal, soldCarValRecived, totalPay;
WriteLine("Insira. O número de vendas efetuadas:" +
    "\n        O valor total de suas vendas:" +
    "\n        Seu sálario fixo:");
soldCars = Convert.ToDouble(ReadLine());
totalVal = Convert.ToDouble(ReadLine());
normalPay = Convert.ToDouble(ReadLine());
soldCarVal = Convert.ToDouble(10000);
soldCarValRecived = Convert.ToDouble(((soldCarVal * 5) / 100));
totalPay = Convert.ToDouble(normalPay + (soldCars * soldCarValRecived));
WriteLine($"Valor médio dos carros:{soldCarVal}" +
    $"\nCarros vendidos: {soldCars}" +
    $"\nValor total das vendas: {totalVal}" +
    $"\nSálario fixo: {normalPay}" +
    $"\nValor recebido por carro vendido: {soldCarValRecived}" +
    $"\nPagamento total: {totalPay}");
