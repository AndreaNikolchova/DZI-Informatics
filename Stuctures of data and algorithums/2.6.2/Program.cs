StreamReader streamReader = new StreamReader("");
List<string> names = streamReader.ReadToEnd().Split(" - ").ToList();
Dictionary<string, string> result = new Dictionary<string, string>();
for (int i = 0; i < names.Count - 1; i++)
{
    result[names[i]] = names[i + 1];
}
Console.WriteLine(result.Values.Max());
