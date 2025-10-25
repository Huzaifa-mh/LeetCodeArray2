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
            else if (nums[i] > target && nums[i - 1] < target)
            {
                return i;
            }
            else
            {
                possibleindex++;
            }
        }
        return possibleindex;
    }
    private static void Main(string[] args)
    {
        int[] array = {1, 3, 5, 6 };
        int result = SearchInsert(array, 4);
        Console.WriteLine(result);
    }
}