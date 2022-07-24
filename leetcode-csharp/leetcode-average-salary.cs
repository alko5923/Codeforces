public class SolutionSalary {
    public double Average(int[] salary) {
        Array.Sort(salary);
        double arraySum = 0;
        double averageSalary = 0;
        
        for (int i = 1; i < salary.Length-1; i++)
        {
            arraySum += salary[i];
        }
        
        int length = salary.Length-2;
        averageSalary = arraySum / length;
        return averageSalary;
    }

}