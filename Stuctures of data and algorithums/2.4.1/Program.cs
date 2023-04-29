int n = int.Parse(Console.ReadLine());
List<int> list = new List<int>();

for (int i = 0; i < n; i++)
{
    list.Add(int.Parse(Console.ReadLine()));
}

list.Sort();

int min = 1000;

for (int i = 0; i < n - 2; i++)
{
    if (min > Math.Abs(list[i] - list[i + 1]))
    {
        min = Math.Abs(list[i] - list[i + 1]);
    }
}
Console.WriteLine(min);
