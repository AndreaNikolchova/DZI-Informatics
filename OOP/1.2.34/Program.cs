int start = int.Parse(Console.ReadLine()!);
int end = int.Parse(Console.ReadLine()!);
long result = 0;
long count = 0;
for (int i = start; i <= end; i++)
{
    if (i % 2 == 0)
    {
        result += i;
        count++;
    }
}
result = result/(count);
Console.WriteLine(result);
