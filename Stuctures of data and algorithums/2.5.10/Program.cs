List<string> line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
for (int i = 0; i < line.Count; i++)
{
    if (line[i].Contains("<upcase>"))
    {
        line[i] = line[i].Replace("<upcase>", "");
        line[i] = line[i].Replace("</upcase>", "");
        line[i] = line[i].ToUpper();
    }
}
Console.WriteLine(String.Join(" ", line));

