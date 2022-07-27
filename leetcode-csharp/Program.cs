namespace LeetcodeProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            SolutionLargestPerimeter solution = new SolutionLargestPerimeter();
            int[] nums = new int[] {1,2,1};
            int result = solution.LargestPerimeter(nums);
            Console.WriteLine(result);
        }
    }
}