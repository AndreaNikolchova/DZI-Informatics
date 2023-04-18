int n =  int.Parse(Console.ReadLine()!);
for(int i = 1; i <= n; i++)
{
    if(i == 1)
    {
        Console.WriteLine("*");
        continue;
    }
    for (int k = 1; k <=i+i-1; k++)
    {
        Console.Write("*");

    }
    Console.WriteLine();
}

