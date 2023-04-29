class Program
{
    public static double sum;
    public static int count = 0;
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()!);
        int x = int.Parse(Console.ReadLine()!);
        Recursion(n);
    }
    public static void SqrtRecursion(int n)
    {
        if (n == 0)
        {
            Console.WriteLine(sum);
            return;
        }
        if (count == 0)
        {
            sum = Math.Sqrt(n);
        }
        else
        {

            sum = Math.Sqrt(n + sum);
        }
        count++;
        SqrtRecursion(n - 1);
    }
    public static void RationalsRecursion(int n,int x)
    {
        if (n == 0)
        {
            Console.WriteLine(sum+1);
            return;
        }
        sum+= 1/Math.Pow(x,n);
        RationalsRecursion(n - 1,x);
    }

    public static void PowRecursion(int n,int x)
    {
        if (n == 0)
        {
            Console.WriteLine(sum + 1);
            return;
        }
        sum += Math.Pow(x, n);
        PowRecursion(n - 1, x);
    }
    public static void Recursion(int n)
    {
        if(n == 0)
        {
            Console.WriteLine(sum);
            return;
        }
        sum += n*(n-1);
        Recursion(n-1);
    }


}