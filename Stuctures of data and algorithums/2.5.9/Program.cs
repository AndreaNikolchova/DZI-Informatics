string line  =  Console.ReadLine().ToLower();

var result = String.Join("",line.Reverse().ToArray()).ToLower();

if(line == result)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Не");
}
