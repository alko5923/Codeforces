public class SolutionPerimeter 
{
    public int LargestPerimeter(int[] nums)
    {
        Array.Sort(nums);
        List<int> allAcceptablePerimeters = new List<int>();
        int largestPerimeter = 0;
        for (int i = 0; i < nums.Length-2; i++)
        {
            int a = nums[i];
            int b = nums[i+1];
            int c = nums[i+2];
            if (a + b > c)
            {
                int perimeter = a + b + c;
                allAcceptablePerimeters.Add(perimeter);
            }
        }
            if (allAcceptablePerimeters.Count() > 0)
            {
                largestPerimeter = allAcceptablePerimeters.Max();
            } 
            return largestPerimeter;
    }
}