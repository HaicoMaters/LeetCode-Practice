// Last updated: 22/10/2026, 09:40:39
1public class Solution {
2    public int SumOddLengthSubarrays(int[] arr) {
3        int n = arr.Length;
4        int sum = 0;
5
6        for (int i = 0; i < n; i++)
7        {
8            for (int j = i; j < n; j += 2)
9            {
10                for (int k = i; k < j + 1; k++)
11                {
12                    sum += arr[k];
13                }
14            }
15        } 
16
17        return sum;
18    }
19}