// Last updated: 04/08/2026, 10:14:41
1public class Solution {
2    public IList<int> FindMissingElements(int[] nums) {
3        HashSet<int> present = new HashSet<int>(nums);
4        List<int> missing = new List<int>();
5
6        int min = nums.Min();
7        int max = nums.Max();
8
9        for (int i = min; i < max; i++)
10        {
11            if (!present.Contains(i)) missing.Add(i);
12        }
13
14        return missing;
15    }
16}