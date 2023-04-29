string[] mounts = { "януари", "февруари", "март", "април", "май", "юни","юли","август","септември","октомври","ноември","декември"};
char input = char.Parse(Console.ReadLine());
while (char.IsLetter(input))
{
    int count = 0;
    foreach(string mount in mounts)
    {
        if (mount.Contains(input.ToString().ToLower()))
        {
            count++;
        }
    }
    Console.WriteLine(count);
    input = char.Parse(Console.ReadLine());
}