// Last updated: 25/08/2026, 09:19:19
1public class Solution {
2    public int MissingMultiple(int[] nums, int k) {
3        HashSet<int> seen = new HashSet<int>();
4
5        foreach (int num in nums)
6        {
7            seen.Add(num);
8        }  
9
10        int missing = k;
11
12        while(seen.Contains(missing))
13        {
14            missing += k;
15        }
16
17        return missing;
18    }
19}