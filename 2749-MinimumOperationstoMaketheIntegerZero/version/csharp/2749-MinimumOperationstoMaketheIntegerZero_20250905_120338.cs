// Last updated: 05/09/2025, 12:03:38
public class Solution {
    public int MakeTheIntegerZero(int num1, int num2) {
        if (num1 == 0) return 0;

        for (int i = 0; i <= 60; i++)
        {
            long sum = (long)num1 - (long) i * num2;
            if (sum < 0) continue;
            if (sum < i) continue;
            
            int ones = 0;

            while (sum  > 0)
            {
                ones += (int)(sum & 1L);
                sum >>= 1;
            }

            if (ones <= i) return i;
        }
        
        return -1;
    }
}