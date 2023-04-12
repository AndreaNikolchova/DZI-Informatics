int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
List<int> list = new List<int>() { a, b, c };
list.Sort();
Console.WriteLine(String.Join(" ", list));
