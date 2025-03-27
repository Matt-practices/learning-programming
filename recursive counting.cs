class Program
{
    static void Main()
    {
        Console.WriteLine("test");
        Console.WriteLine(Counting(10));
        Console.ReadLine();
    }


    public static int Counting(int inputnumber)
    {
        if (inputnumber <= 1) return inputnumber;
        return inputnumber + Counting(inputnumber - 1);

    }

}
