/*
 Implement shell sort on an unsorted array of numbers. Take the array input from user.
*/

namespace Assignment_7._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -11, 12, 13, -15, -4, -9, -13 };

            ShellSort shellSort = new ShellSort();

            shellSort.ShellSorted(nums);

            foreach (int i in nums) 
            {
                Console.Write(i);
            }

        }

        public class ShellSort
        {
            public int ShellSorted(int[] nums)
            {
                for (int h = nums.Length / 2; h > 0; h /= 2)// starts with a large gap in sublist for comparison then it is reduced by half again. h = gap.
                {
                    for (int i = h; i < nums.Length; i++) //middle loop will iterate through the elements starting from the index 'h' for the current gap
                    {
                        int temp = nums[i]; // store the current element 'nums[i]' as temp
                        int j; // variable 'j' is intitialized to 'i'
                        for (j = i; j >= h && nums[j - h] > temp; j -= h) //insertion sor for the current gap
                        {
                            nums[j] = nums[j - h]; // if the condition is met nums[j-h] will be assigned to nums[j]
                        }
                        nums[j] = temp; // this will place temp value in nums[j] location.
                    }
                } return 0;
            }
        }
    }
}
