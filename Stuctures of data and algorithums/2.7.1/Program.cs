Stack<char> stack = new Stack<char>();
string line = Console.ReadLine();
int count = 0;
foreach (var item in line)
{
    if (item == '(')
    {
        stack.Push(item);

    }
    if (item == ')'&& stack.Count>0)
    {
        stack.Pop();
        count++;
    }

}
if(stack.Count > 0)
{
    Console.WriteLine("Грешен израз");
}
else
{
    Console.WriteLine(count);
}