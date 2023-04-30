StreamReader streamReader = new StreamReader("");
List<string> names = streamReader.ReadToEnd().Split(Environment.NewLine).ToList();
int n = int.Parse(Console.ReadLine());
if (names.Count < n)
{
    Console.WriteLine("Няма достатъчно данни");
    return;
}
Random random = new Random();
for (int i = 0; i < n; i++)
{
    int num =  random.Next(0, names.Count);
    Console.WriteLine(names[num]);
    names.RemoveAt(num);
}