string line = Console.ReadLine();
int k = int.Parse(line.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0]);
int n = int.Parse(line.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
Queue<int> queue = new Queue<int>();
queue.Enqueue(k);
for (int i = 2; i <= n; i++)
{
    if (i % 2 == 0)
    {
        int number = i / 2;
        int needed = queue.ElementAt(number - 1) + 1;
        queue.Enqueue(needed);
    }
    else
    {
        int number = (i - 1) / 2 ;
        int needed = 2 * queue.ElementAt(number - 1);
        queue.Enqueue(needed);
    }
}

Console.WriteLine(queue.ElementAt(n-1));
