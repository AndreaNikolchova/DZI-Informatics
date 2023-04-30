using System.Text;

Random random = new Random();
List<int> list = new List<int>() { 35, 36, 37, 38, 94, 42 };

for (int i = 65; i <= 90; i++)
{
    list.Add(i);
}
for (int i = 97; i <= 122; i++)
{
    list.Add(i);
}
for (int i = 48; i <= 57; i++)
{
    list.Add(i);
}
int numLenght = random.Next(8, 16);
StringBuilder sb = new StringBuilder();
while (!sb.ToString().Any(x => char.IsLower(x))|| !sb.ToString().Any(x => char.IsUpper(x)) || !sb.ToString().Any(x => char.IsDigit(x)) || !sb.ToString().Any(x => !char.IsLetterOrDigit(x)))
{
    sb.Clear();
    for (int i = 0; i < numLenght; i++)
    {
        sb.Append((char)list[random.Next(0, list.Count - 1)]);
    }
  
}
Console.WriteLine(sb.ToString());