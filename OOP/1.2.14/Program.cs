
double D = double.Parse(Console.ReadLine()!);
double H = double.Parse(Console.ReadLine()!);

double L = double.Parse(Console.ReadLine()!);
double W = double.Parse(Console.ReadLine()!);


int piecesCount = (int)Math.Round(D / W);
double metersNeeded = piecesCount * H;
int result = (int) Math.Ceiling(metersNeeded/L);
Console.WriteLine(result);

