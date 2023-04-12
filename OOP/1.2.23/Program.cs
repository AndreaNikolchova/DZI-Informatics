string line = Console.ReadLine()!;
int firstNumber = 0;
string numLine = "";

for (int i = 0; i < line.Length; i++)
{
    if ((int)line[i] % 2 != 0)
    {
        firstNumber++;
    }
    if (i % 2 == 0)
    {
        numLine+=line[i];
    }
}
int number = int.Parse(numLine) - int.Parse(String.Join("",numLine.Reverse().ToArray()));
if (number < 0)
{
    number = number * -1;
}
string result = firstNumber.ToString();
if (number > 0 && number < 10)
{
    result += $"00{number}";
}
else if (number > 10 && number < 100)
{
    result += $"0{number}";
}
else
{
    result += number.ToString();
}
Console.WriteLine(result);


