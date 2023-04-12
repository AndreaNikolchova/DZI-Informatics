int n =  int.Parse(Console.ReadLine()!);
int minLenght = 1000;
int minIcline = 1000;
for (int i = 0; i < n; i++)
{
    int lenght = int.Parse(Console.ReadLine()!);
    int incline = int.Parse(Console.ReadLine()!);
    if (minLenght > lenght)
    {
        minLenght = lenght;
        minIcline = incline;
    }
    if (minLenght == lenght)
    {
        if (minIcline > incline)
        {
            minIcline = incline;
        }
    }
}
Console.WriteLine(minLenght + " " + minIcline);

