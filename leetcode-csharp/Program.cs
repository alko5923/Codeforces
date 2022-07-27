namespace LeetcodeProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            SolutionPerimeter solution = new SolutionPerimeter();
            int[] nums = new int[] {2, 1, 2};
            int result = solution.LargestPerimeter(nums);
            Console.WriteLine(result);
        }
    }
}