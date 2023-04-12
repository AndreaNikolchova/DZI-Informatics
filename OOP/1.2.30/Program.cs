int n = int.Parse(Console.ReadLine()!);
List<int> list = new List<int>();
for (int i = 0; i < n; i++)
{
    list.Add(int.Parse(Console.ReadLine()!));
}
list.Sort();
Console.WriteLine(list[0] + " " + list[1]);