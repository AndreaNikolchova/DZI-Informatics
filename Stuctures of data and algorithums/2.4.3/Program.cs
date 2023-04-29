using _2._4._3;

List<Triple> triples = new List<Triple>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int firstNumber = int.Parse(Console.ReadLine());
    int secondNumber = int.Parse(Console.ReadLine());
    int thirdNumber = int.Parse(Console.ReadLine());

    triples.Add(new Triple(firstNumber, secondNumber, thirdNumber));
}

triples = triples.OrderBy(x=>x.First).ThenBy(x=>x.Second).ThenBy(x=>x.Third).ToList();

foreach(Triple triple in triples)
{
    Console.WriteLine(triple.First + " " + triple.Second + " " + triple.Third);
}
