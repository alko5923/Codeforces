namespace LeetcodeProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            SolutionPerimeter solution = new SolutionPerimeter();
            int[] nums = new int[] {1,2,1};
            int result = solution.LargestPerimeter(nums);
            Console.WriteLine(result);
        }
    }
}