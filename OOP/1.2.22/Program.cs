double grade = double.Parse(Console.ReadLine()!);
if (grade < 2 || grade > 6)
{
    Console.WriteLine("Невалидна оценка");
    return;

}
if (grade > 2.50)
{
    Console.WriteLine("Слаб");
    return;
}
if (grade >= 2.50 && grade < 3.50)
{
    Console.WriteLine("Среден");
    return;
}
if (grade >= 3.50 && grade < 4.50)
{
    Console.WriteLine("Добър");
    return;
}
if (grade >= 4.50 && grade < 5.50)
{
    Console.WriteLine("Много добър");
    return;
}
if (grade >= 5.50)
{
    Console.WriteLine("Отличен");
    return;
}