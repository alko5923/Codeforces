namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            SolutionDigitsInteger solution = new SolutionDigitsInteger();
            int n = 234;
            int result = solution.SubtractProductAndSum(n);
            Console.WriteLine(result);
        }
    }
}