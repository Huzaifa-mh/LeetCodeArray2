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

            return digits;
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

        string s1 = "123";
        string s2 = s1 + "456";
        Console.WriteLine("///");

        int[] num1 = Array.ConvertAll(s2.ToCharArray(), c => (int)char.GetNumericValue(c));
        foreach (var item in num1)
        {
            Console.WriteLine(item);
        }
    }
}