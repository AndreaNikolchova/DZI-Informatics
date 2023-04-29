List<int> numbers = new List<int>();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < 100; i++)
{
    numbers.Add(i+1);
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine(numbers[numbers.Count/2-1]);
    string line = Console.ReadLine();
    
    if(line == "Надолу")
    {
        numbers.RemoveRange(numbers.Count / 2, numbers.Count/2);
    }
    else if(line == "Нагоре")
    {
        numbers.RemoveRange(0, numbers.Count / 2-1);
    }
    else if(line == "ОК")
    {
        Console.WriteLine("Аз печеля");
        return;
    }
}
Console.WriteLine("Ти спечели");


