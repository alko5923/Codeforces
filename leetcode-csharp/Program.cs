namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            SolutionSalary solution = new SolutionSalary();
            int[] salary = new int[] {4000,3000,1000,2000};
            double result = solution.Average(salary);
            Console.WriteLine(result);
        }
    }
}