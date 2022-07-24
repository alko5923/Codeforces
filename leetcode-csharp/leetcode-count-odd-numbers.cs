public class Solution {
    public int CountOdds(int low, int high) {
        int count = 0;
        bool firstNumOdd = false;
        
        if (low % 2 == 1)
        {
            firstNumOdd = true;
        }
        
        if (firstNumOdd)
        {
            for (int i = low; i < high+1; i+=2)
            {
                count+=1;
            }
        }
        
        else
        {
            for (int i = low+1; i < high+1; i+=2)
            {
                count+=1;
            }
        }
        return count;
    }
}