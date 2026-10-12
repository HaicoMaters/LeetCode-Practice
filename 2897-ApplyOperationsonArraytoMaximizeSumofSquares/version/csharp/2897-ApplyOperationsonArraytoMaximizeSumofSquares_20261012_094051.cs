// Last updated: 12/10/2026, 09:40:51
1public class Solution {
2    public int MaxSum(IList<int> nums, int k) {
3        int mod = 1000000007;
4        long sum = 0;
5
6        int[] bitCounts = new int[30]; // count of set bits that are in each position of each of the values in nums
7
8        // update count
9        foreach (int num in nums)
10        {
11            for (int i = 0; i < 30; i++)
12            {
13                if(((num >> i) & 1) == 1)
14                {
15                    bitCounts[i]++;
16                }
17            }
18        }
19
20        for (int i = 0; i < k; i++)
21        {
22            long num = 0;
23
24            for (int j = 0; j < 30; j++) // use each of the largest remaining bits to get the largest possible num
25            {
26                if (bitCounts[j] > 0) {
27                    num |= (1 << j);
28                    bitCounts[j]--;
29                }
30            }
31
32            long square = (num * num) % mod;
33            sum = (sum + square) % mod;
34        }
35
36        return (int) sum;
37    }
38}