// Last updated: 14/05/2026, 12:00:25
1public class Solution {
2    public bool IsGood(int[] nums) {
3        int n = nums.Length - 1; // in this question
4        int nOccurs = 0;
5        HashSet<int> goodNums = new HashSet<int>();
6
7        foreach (int num in nums)
8        {
9            if (num > n || num < 1) return false;
10
11            if (num == n)
12            {
13                nOccurs++;
14                if (nOccurs > 2) return false;
15                continue; // no need to store in goodNums since being tracked by other variable
16            }
17
18            if (goodNums.Contains(num))
19            {
20                return false;
21            }
22            
23            goodNums.Add(num);
24        }
25        
26
27        return nOccurs == 2;
28    }
29}