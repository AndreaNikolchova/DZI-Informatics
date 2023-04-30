string[] line  = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
int maxLenght = -10;
foreach(string word in line)
{
    if (maxLenght < word.Length)
    {
        maxLenght = word.Length;
    }
}
Console.WriteLine(maxLenght);
