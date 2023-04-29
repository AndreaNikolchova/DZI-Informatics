List<int> nArray = new List<int>();


int n  =  int.Parse(Console.ReadLine());
HashSet<int> result = new HashSet<int>();

for(int i = 0; i < n; i++)
{
    nArray.Add(int.Parse(Console.ReadLine()));
}
int m = int.Parse(Console.ReadLine());
for (int i = 0; i < m; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (nArray.Contains(number))
    {
        result.Add(number);
    }
}

Console.WriteLine(string.Join(" ",result));

