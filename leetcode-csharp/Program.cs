namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            SolutionBits solution = new SolutionBits();
            uint n = 4294967293;
            int result = solution.HammingWeight(n);
            Console.WriteLine(result);
        }
    }
}