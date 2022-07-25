public class SolutionBits
{
    public int HammingWeight(uint n)
    {
        // Solved with the Brian Kerninghan algorithm. 
        // The algorithms unsets the rightmost bit, 
        // thus running for as many iterations as there
        // are set bits. 
        int count = 0;
        while (n!=0)
        {
            n = n & (n-1);
            count ++;
        }
        return count;
    }
}