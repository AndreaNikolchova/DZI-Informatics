string line = Console.ReadLine();
int n = int.Parse(line.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0]);
//Karti
int k = int.Parse(line.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
//mestat
int p = int.Parse(line.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]);
Dictionary<int, List<int>> players = new Dictionary<int, List<int>>();
Queue<int> cards = new Queue<int>();
for (int i = 1; i <= n; i++)
{
    players[i] = new List<int>();
}
for (int i = 1; i <= k; i++)
{
    cards.Enqueue(i);
}
int player = 1;
while (cards.Count > 0)
{
    if (player > players.Keys.Count)
    {
        player = 1;
    }
    players[player].Add(cards.Dequeue());
    for (int i = 0; i < p; i++)
    {
        if (cards.Count == 0)
        {
            break;
        }
        int help = cards.Dequeue();
        cards.Enqueue(help);
    }
    player++;
}
Console.WriteLine(String.Join(" ", players[n]));