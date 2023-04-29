string[] line =  Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
List<string> result = new List<string>();
foreach(var word in line)
{
    List<char> chars = word.ToCharArray().ToList();
    for (int i = 0; i < chars.Count-1; i++)
    {
        if(chars[i] == chars[i + 1])
        {
            chars.Remove(chars[i]);
            i--;
        }
    }
    result.Add(String.Join("",chars));
    
}
Console.WriteLine(String.Join(" ",result));
