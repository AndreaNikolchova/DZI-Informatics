using System.Text.RegularExpressions;

string regexPattern = @"[^<>]+\s\w+";
string line = Console.ReadLine();
Regex regex = new Regex(regexPattern);

line = regex.Match(line).ToString();
Console.WriteLine(line);
