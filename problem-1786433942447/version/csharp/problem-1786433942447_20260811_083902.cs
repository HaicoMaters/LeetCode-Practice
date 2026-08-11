// Last updated: 11/08/2026, 08:39:02
1public class Solution {
2    public int CountDigitOccurrences(int[] nums, int digit) {
3        int occurences = 0;
4
5        foreach (int num in nums)
6        {
7            int n = num;
8            while (n > 0)
9            {
10                if (n % 10 == digit) occurences++;
11                n /= 10;
12            }
13        }
14
15        return occurences;
16    }
17}