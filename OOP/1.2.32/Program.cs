int n = int.Parse(Console.ReadLine()!);
int minNumber = 10000;
int maxNumber = 0;
int count = 0;
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine()!);
    if (number == i + 1)
    {
        count++;
        if (minNumber > number)
        {
            minNumber = number;
        }
        if (number > maxNumber)
        {
            maxNumber = number;
        }

    }
}
if(minNumber == 10000)
{
    minNumber = 0;
}
if(count == 0||count == 1)
{
    minNumber = 0;
    maxNumber = 0;
}
Console.WriteLine(minNumber + " " + maxNumber);
