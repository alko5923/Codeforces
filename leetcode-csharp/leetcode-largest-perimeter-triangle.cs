public class SolutionPerimeter 
{
    public int LargestPerimeter(int[] nums)
    {
        Array.Sort(nums);
        for (int i = 0; i < nums.Length-2; i++)
        {
            if (nums[i] + nums[i+1] < nums[i+2])
            {
                return nums.Sum();
            }
        }
            return 0;
    }
}