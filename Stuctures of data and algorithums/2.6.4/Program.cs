string line = Console.ReadLine();
StreamReader reader = new StreamReader($"{line}.txt");
Dictionary<string,double> students = new Dictionary<string,double>();
while (reader.EndOfStream)
{
    students[reader.ReadLine()!.Split(" - ").ToArray()[0]] = double.Parse(reader.ReadLine()!.Split(" - ").ToArray()[1]);
}
students.OrderByDescending(x => x.Value);
foreach(var student in students)
{
    Console.WriteLine(student.Key + " - " + student.Value);
}