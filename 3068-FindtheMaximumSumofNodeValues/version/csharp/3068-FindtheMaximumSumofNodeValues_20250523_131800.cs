// Last updated: 23/05/2025, 13:18:00
public class Solution {
    public long MaximumValueSum(int[] nums, int k, int[][] edges)
    {
        long sum = 0;        
        int xorCount = 0;       
        int minLoss = int.MaxValue; // Tracks the smallest possible loss/gain 

        foreach (int num in nums)
        {
            int xor = num ^ k;                 
            sum += Math.Max(num, xor);          

            if (xor > num)
            {
                xorCount++;
                minLoss = Math.Min(minLoss, xor - num);
            }
            else
            {
                minLoss = Math.Min(minLoss, num - xor);
            }
        }

        // Must be even number of operations so take away the smallest opperation (gain/loss)
        if (xorCount % 2 == 1)
        {
            sum -= minLoss;
        }

        return sum;
    }
}