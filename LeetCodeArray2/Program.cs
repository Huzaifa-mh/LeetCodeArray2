internal class Program
{
    public static int SearchInsert(int[] nums, int target)
    {
        int possibleindex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                return i;
            }
            else if (nums[i] < target)
            {
                possibleindex = i;
                continue;
            }
        }
        return possibleindex;
    }
    private static void Main(string[] args)
    {
        int[] array = {1, 3, 5, 6 };
        int result = SearchInsert(array, 5);
        Console.WriteLine(result);
    }
}