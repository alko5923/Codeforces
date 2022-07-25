namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            SolutionBits solution = new SolutionBits();
            uint n = 9;
            int result = solution.HammingWeight(n);
            Console.WriteLine(result);
        }
    }
}