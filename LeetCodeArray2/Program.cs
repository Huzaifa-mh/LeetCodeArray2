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
    public static int[] PlusOne(int[] digits)
    {
        int len = digits.Length;
        if(len ==1 && digits[0] == 9)
        {
            Array.Resize(ref digits, 2);
            digits[0] = 1;
            digits[1] = 0;
        }
        else
        if (digits[len - 1] < 9)
        {
            digits[len - 1]++;
            return digits;
        }
        else if(digits[len - 1] == 9 && digits[len - 2] < 9)
        {
            digits[len - 1] = 0;
            digits[len - 2]++;
        }

        return digits;
    }

                
    private static void Main(string[] args)
    {
        int[] array = {1, 3, 5, 6 };
        int result = SearchInsert(array, 4);
        Console.WriteLine(result);


        int[] digit = { 9};
        //Array.Clear(digit, 0, 2);
        //foreach (var item in digit)
        //{
        //    Console.WriteLine(item);
        //}

        int[] output = PlusOne(digit);
        foreach (var item in output)
        {
            Console.WriteLine(item);
        }
    }
}