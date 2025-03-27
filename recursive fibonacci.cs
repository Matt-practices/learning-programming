class Program
{
    static void Main()
    {
        Console.WriteLine(F(10));
        Console.Read();
    }
    public static long F(long n)
    {
        if (n == 0 || n == 1) return n;
        else return F(n-1)+F(n-2);

    }
}