string line = Console.ReadLine()!;
int rows = int.Parse(line.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0]);
int cols = int.Parse(line.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
int illApplesCount = int.Parse(line.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]);

string[,] matrix = new string[rows, cols];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = "apple";
    }
}
for (int i = 0; i < illApplesCount; i++)
{
    string indexes = Console.ReadLine()!;
    int rowIndex = int.Parse(indexes.Split(" ")[0]);
    int colIndex = int.Parse(indexes.Split(" ")[1]);
    matrix[rowIndex, colIndex] = "ill";
}
int allApples = rows * cols;
int count = 0;
while (CheckIfAllApplesAreIll(matrix) != allApples)
{
    MakeApplesIll(matrix);
    count++;
}

Console.WriteLine(count);
static void MakeApplesIll(string[,] matrix)
{
    List<Tuple<int, int>> list = new List<Tuple<int, int>>();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == "ill" && !list.Contains(new Tuple<int, int>(i, j)))
            {
                if (j + 1 != matrix.GetLength(1))
                {
                    if (matrix[i, j + 1] != "ill")
                    {
                        matrix[i, j + 1] = "ill";
                        list.Add(new Tuple<int, int>(i, j + 1));
                    }
                }
                if (j - 1 >= 0)
                {
                    if (matrix[i, j - 1] != "ill")
                    {
                        matrix[i, j - 1] = "ill";
                        list.Add(new Tuple<int, int>(i, j - 1));
                    }
                }
                if (i + 1 != matrix.GetLength(0))
                {
                    if (matrix[i + 1, j] != "ill")
                    {
                        matrix[i + 1, j] = "ill";
                        list.Add(new Tuple<int, int>(i + 1, j));
                    }
                }
                if (i - 1 >= 0)
                {
                    if (matrix[i - 1, j] != "ill")
                    {
                        matrix[i - 1, j] = "ill";
                        list.Add(new Tuple<int, int>(i - 1, j));
                    }

                }
            }
        }
    }
}
static int CheckIfAllApplesAreIll(string[,] matrix)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == "ill")
            {
                count++;
            }
        }
    }
    return count;

}
