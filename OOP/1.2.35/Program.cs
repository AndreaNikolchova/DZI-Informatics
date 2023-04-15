string line = Console.ReadLine()!;
var lineReverse = String.Join("",line.Reverse().ToArray());
if (line == lineReverse)
{
    Console.WriteLine("Yes");
    return;
}
Console.WriteLine("No");
