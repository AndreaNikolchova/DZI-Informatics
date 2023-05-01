string line = Console.ReadLine();
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
    string indexes = Console.ReadLine();
    int rowIndex = int.Parse(indexes.Split(" ")[0]) - 1;
    int colIndex = int.Parse(indexes.Split(" ")[1]) - 1;
    matrix[rowIndex, colIndex] = "ill";
}
while (true)
{

}

static void MakeApplesIll(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] == "ill")
            {

            }
        }
    }

}
