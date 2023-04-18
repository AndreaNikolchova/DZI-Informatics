namespace _1._3._14
{
    public static class Distances
    {
        public static double GetEvklidovo(int x1, int x2,int y1,int y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
        public static double GetManhatynsko(int x1, int x2, int y1, int y2)
        {
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        }
        public static double GetChebishevoto(int x1, int x2, int y1, int y2)
        {
            return (Math.Abs(x1 - x2) + Math.Abs(y1 - y2) + Math.Abs(Math.Abs(x1 - x2)- Math.Abs(y1 - y2)))/2;
        }
    }
}
