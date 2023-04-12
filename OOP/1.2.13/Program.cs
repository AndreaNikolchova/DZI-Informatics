
int money = int.Parse(Console.ReadLine()!);
decimal exchangeRate = decimal.Parse(Console.ReadLine()!);

decimal result = (decimal) money / exchangeRate;
Console.WriteLine(Math.Floor(result) + " евро");
Console.WriteLine(Math.Round(result*100%100*exchangeRate) + " стотинки");

