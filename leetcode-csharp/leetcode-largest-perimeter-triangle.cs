public class SolutionLargestPerimeter {
    // Sort the array. For any c in the array, we choose the largest
    // possible a <= b <= c. If this forms a triangle (a + b > c), we
    // return the answer. 
    public int LargestPerimeter(int[] nums) {
        Array.Sort(nums);
        for (int i = nums.Length - 3; i >= 0; i--)
        {
            if (nums[i]+nums[i+1]>nums[i+2])
            {
                return nums[i]+nums[i+1]+nums[i+2];
            }
        }
        return 0;
    }
}