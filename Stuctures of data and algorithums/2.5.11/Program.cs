string line = Console.ReadLine();
List<string> words = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
foreach (var word in words)
{
    line = line.Replace(word.ToLower(), "***");
    line = line.Replace(word.ToUpper(), "***");
}
Console.WriteLine(line);