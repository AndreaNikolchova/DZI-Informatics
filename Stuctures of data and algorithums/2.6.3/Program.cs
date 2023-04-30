string fileName = Console.ReadLine()!;
switch (fileName)
{
    case "1": Console.Write("Понеделник"); break;
    case "2": Console.Write("Вторник"); break;
    case "3": Console.Write("Сряда"); break;
    case "4": Console.Write("Четвъртък"); break;
    case "5": Console.Write("Петък"); break;
    default:
        Console.WriteLine("Няма");
        return;
}
StreamReader reader = new StreamReader($"{fileName}.txt");
int count = 0;
int countDaysOff = 0;
while (reader.EndOfStream)
{
    count++;
    string line = reader.ReadLine()!;
    if (line.Contains('-'))
    {
        countDaysOff++;
    }
}
Console.Write(count - countDaysOff);
Console.WriteLine();
