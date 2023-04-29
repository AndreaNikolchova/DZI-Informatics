Random random =  new Random();
List<int> result = new List<int>();
for (int i = 0; i < 6; i++)
{
    result.Add(random.Next(1,49));
}
result.Sort();
Console.WriteLine(String.Join(" ",result));
