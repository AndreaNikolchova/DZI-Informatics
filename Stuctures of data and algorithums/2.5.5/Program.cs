string[,] matrix = new string[4, 4];
Dictionary<int, List<string>> map = new Dictionary<int, List<string>>();
for (int i = 0; i < 4; i++)
{
    List<string> line = Console.ReadLine()!
          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
          .ToList();
    map.Add(i, line);
    for (int k = 0; k < 4; k++)
    {
        matrix[i, k] = line[k];
    }
}
Console.WriteLine();
int row = 0;
int max = -10;
for (int k = 0; k < 3; k++)
{
    int result = 1;
    bool flag = false;
    if (map[0][k] == map[0][k + 1])
    {
        result++;
        flag = true;
    }
    while (map[row + 1].Contains(matrix[row, k]))
    {
        List<int> indexes = new List<int>();
        for (int j = 0; j < map[row + 1].Count; j++)
        {
            if (map[row + 1][j] == matrix[row, k])
            {
                indexes.Add(j);
            }
        }
        if (indexes.Count == 1)
        {
            if (indexes[0] == k)
            {
                result++;
            }
        }
        for (int p = 0; p < indexes.Count - 1; p++)
        {
            if (indexes[p] == k || flag && indexes[p] == k+1)
            {
                result++;
            }
            if (indexes[p + 1] == indexes[p] + 1)
            {
                result++;
            }
        }
        row++;
        if (row == 3)
        {
            break;
        }
    }
    row = 0;
    if (max < result)
    {
        max = result;
    }


}
Console.WriteLine(max);


