List<KeyValuePair<int,int>> list = new List<KeyValuePair<int, int>>();
int n  = int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    int numberOne = int.Parse(Console.ReadLine());
    int numberTwo = int.Parse(Console.ReadLine());
    list.Add(new KeyValuePair<int,int>(numberOne,numberTwo));
}
list  = list.OrderBy(x => x.Key).ThenBy(x=> x.Value).ToList();
foreach(KeyValuePair<int,int> pair in list)
{
    Console.WriteLine(pair.Key + " " + pair.Value);
}