int day = int.Parse(Console.ReadLine());
int month = int.Parse(Console.ReadLine());
int year = int.Parse(Console.ReadLine());
double daysAhead = double.Parse(Console.ReadLine());

var dateTime = new DateTime(year, month, day);
var result = dateTime.AddDays(daysAhead);

Console.WriteLine(result.ToString("dd:MM:yyyy"));
