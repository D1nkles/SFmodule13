class Program
{
    static bool IsSorted(int[] arr)
    {
        bool isSorted = true;

        for (int i = 0; i < arr.Length; i++)
        {
            if (!(arr[i] < arr[i + 1]))
            {
                isSorted = false;
                return isSorted;
            }
        }
        return isSorted;
    }
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 99, 5, 6, 7, 8, 9 };
        bool isSorted = IsSorted(arr);
    }
}