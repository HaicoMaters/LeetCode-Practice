// Last updated: 15/09/2026, 13:49:19
1public class Solution {
2    public int MinimumSum(int num) {
3        int[] digits = new int[4];
4
5        for (int i = 0; i < 4; i++)
6        {
7            digits[i] =  num % 10;
8            num /= 10;
9        }
10
11        Array.Sort(digits);
12
13        return digits[0] * 10 + digits[1] * 10 + digits[2] + digits[3];
14    }
15}