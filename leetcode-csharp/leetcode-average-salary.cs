public class SolutionSalary {
    public double Average(int[] salary) {
        double totalSum = salary.Sum();
        int minSalary = salary.Min();
        int maxSalary = salary.Max();

        totalSum = totalSum - minSalary - maxSalary;
        int length = salary.Length-2;
        double averageSalary = totalSum / length;
        return averageSalary;
    }

}