class Program
{
    static void Main()
    {
        List<int> list = new List<int> {-1, 0, 1, 2, 3, 4, 7, 9, 10, 20 };
        Console.WriteLine(FindMid(list, 0, list.Count-1, 10));
        Console.ReadLine();
    }
    public static int FindMid(List<int> A, int left, int right, int x)
    {
        if(left>right) return -1;

        int mid = (left + right) / 2;
        if (A[mid]==x) return mid;

        if (A[mid] > x)
        {
            return FindMid(A, left, mid - 1, x);
        }

        return FindMid(A, mid+1, right, x);
    }
}