// Last updated: 25/11/2025, 12:48:26
public class Solution {
    public int SmallestRepunitDivByK(int k) {
        if (k % 2 == 0 || k % 5 == 0) return -1; //cannot be even or divisible by 5 (5 is 101 the 0 will always be there)

        int rem = 0;

        for (int len = 1; len <= k; len++)
        {
            rem = (rem * 10 + 1) % k;

            if (rem == 0)
            {
                return len;
            }
        }

        return -1;
    }
}