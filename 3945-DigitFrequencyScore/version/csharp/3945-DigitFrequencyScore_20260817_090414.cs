// Last updated: 17/08/2026, 09:04:14
1public class Solution {
2    public int DigitFrequencyScore(int n) {
3        int score = 0;
4        int num = n;
5
6        while (num > 0)
7        {
8            score += num % 10;
9            num /= 10;
10        }
11
12        return score;
13    }
14}