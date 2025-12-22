// Last updated: 22/12/2025, 15:23:41
1public class Solution {
2    public int MinOperations(int[] nums, int k) {
3        int numXor = 0;
4
5        foreach (int num in nums)
6        {
7            numXor ^= num;
8        }   
9
10        if (numXor == k) return 0;
11        
12        int target = numXor ^ k;
13        int ops = 0;
14
15        while (target > 0)
16        {
17            ops++;
18            target &= (target - 1);
19        }
20
21        return ops;
22    }
23}