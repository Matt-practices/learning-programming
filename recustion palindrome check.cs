using System;

class Program
{
    public static bool IsPalindrome(string input)
    {
        if(input.Length ==0 || input.Length == 1)
        {
            return true;
        }

        if (input[0] == input[input.Length - 1])
        {
            return IsPalindrome(input.Substring(1, input.Length - 2));
        }
        return false;
    }

    static void Main()
    {
        bool check = IsPalindrome("racecar");
        Console.WriteLine(check);
        Console.ReadLine();
    }
}
