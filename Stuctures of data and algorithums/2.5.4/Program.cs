List<int> line = Console.ReadLine()
    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
    .Select(x=> int.Parse(x))
    .ToList();

int countPeeks = 0;
int countValleys = 0;
for (int i = 1; i < line.Count - 1; i++)
{
    if (i == 1)
    {
        if (line[i] > line[i + 1] && line[i] > line[i + 2])
        {
            countPeeks++;
        }
        else if (line[i] < line[i + 1] && line[i] < line[i + 2])
        {
            countValleys++;
        }
    }
    else if (i == line.Count - 2)
    {
        if (line[i] > line[i - 1] && line[i] > line[i - 2])
        {
            countPeeks++;
        }
        else if (line[i] < line[i - 1] && line[i] < line[i - 2])
        {
            countValleys++;
        }
    }
    else
    {
        if (line[i] > line[i + 1] && line[i] > line[i + 2])
        {
            countPeeks++;
        }
        else if (line[i] < line[i + 1] && line[i] < line[i + 2])
        {
            countValleys++;
        }
        if (line[i] > line[i - 1] && line[i] > line[i - 2])
        {
            countPeeks++;
        }
        else if (line[i] < line[i - 1] && line[i] < line[i - 2])
        {
            countValleys++;
        }
    }
}
Console.WriteLine(countPeeks + " " + countValleys);

