// Last updated: 16/12/2025, 02:45:04
1public class Solution {
2    List<IList<int>> subsets;
3    public IList<IList<int>> SubsetsWithDup(int[] nums) {
4        subsets = new List<IList<int>>();
5        int[] freq = new int[21]; // -10 <= nums[i] <= 10 (num + 10 = index)
6
7        foreach (int num in nums)
8        {
9            freq[num+10]++;
10        }
11        
12        Backtrack(0, freq, new List<int>());
13        return subsets;
14    }
15
16    public void Backtrack(int idx, int[] freq, List<int> subset)
17    {
18        subsets.Add(new List<int>(subset));
19
20        for (int i = idx; i < 21; i++)
21        {
22            for (int j = 0; j < freq[i]; j++)
23            {
24                subset.Add(i-10);
25                Backtrack(i+1, freq, subset);
26            }
27            for(int j = 0; j < freq[i]; j++)
28            {
29                subset.RemoveAt(subset.Count - 1);
30            }
31        }
32    }
33}