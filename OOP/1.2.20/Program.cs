int hour = int.Parse(Console.ReadLine());
int minute = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
if (hour < 0 || hour > 23||  minute < 0|| minute > 59 || second < 0 || second > 59)
{
    Console.WriteLine("Некоректни данни");
    return;
}
second++;
if(second == 60)
{
    minute++;
    second = 0;
}
if(minute == 60)
{
    hour++;
    minute = 0;
}
if(hour == 24)
{
    hour = 0;
}
string hourResult = hour < 10 ? $"0{hour}:" : $"{hour}:";
string minResult = minute < 10 ? $"0{minute}:" : $"{minute}:";
string secondResult = second < 10 ? $"0{second}" : $"{second}";
Console.WriteLine(hourResult + minResult + secondResult);