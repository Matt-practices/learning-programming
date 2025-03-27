using System;

class Program
{
    static void Main()
    {
        string binary = ToBinary(233, "");
    }


    public static string ToBinary(int decimalnum, string result)
    {
        if (decimalnum == 0) { return result; }

        result = decimalnum % 2 + result;
        return ToBinary(decimalnum / 2, result);
    }

}
