public class SolutionBits
{
    public int HammingWeight(uint n)
    {
        String nString = Convert.ToString(n, 2);
        int count = 0;

        foreach (char c in nString)
        {
            if (c == '1')
            {
                count++;
            } 
        }
        return count;
    }
}