int n = int.Parse(Console.ReadLine()!);
int d = int.Parse(Console.ReadLine()!);
int k = int.Parse(Console.ReadLine()!);
List<int> list = new List<int>();
for (int i = 1; i <= n; i++)
{
    list.Add(i);
}
int sum = 0;
for (int i = 0; i < d; i++)
{
    sum += list[i];
}
Console.WriteLine(sum * k);

