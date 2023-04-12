int first = int.Parse(Console.ReadLine()!);
int second = int.Parse(Console.ReadLine()!);
int third = int.Parse(Console.ReadLine()!);
int fourth = int.Parse(Console.ReadLine()!);
string count = "";
if(first==2||second==2||third==2||fourth==2)
{
    Console.WriteLine("No");
    return;
}
if (first == 6)
{
    count+="*";
}
if (second == 6)
{
    count += "*";
}
if (third == 6)
{
    count += "*";
}
if(fourth == 6)
{
    count += "*";
}
Console.WriteLine(count);
