namespace LeetcodeProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            SolutionNearestPoint solution = new SolutionNearestPoint();
            int x = 3, y = 4;
            int [][] points = 
            {
                new int[] {2, 3}
            };
            int result = solution.NearestValidPoint(x, y, points);
            Console.WriteLine(result);
        }
    }
}