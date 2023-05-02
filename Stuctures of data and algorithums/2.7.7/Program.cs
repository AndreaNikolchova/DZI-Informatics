string[] line = Console.ReadLine()!.ToLower().Split(" ").ToArray();
SortedDictionary<string, int> words = new SortedDictionary<string, int>();
foreach (var word in line)
{
    string actual = word;
    for (int i = 0; i < word.Length; i++)
    {
        if (!char.IsLetterOrDigit(word[i]))
        {
            actual = word.Remove(i);
        }
    }
    if (!words.ContainsKey(actual))
    {
        words.Add(actual, 1);
    }
    else
    {
        words[actual]++;
    }

}
string result = "";
foreach (var word in words)
{
    result += $" {word.Key}  {word.Value};";
}
Console.WriteLine(result.TrimStart());


