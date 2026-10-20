// Last updated: 20/10/2026, 10:35:43
1public class Solution {
2    public int SortableIntegers(int[] nums) {
3        int n = nums.Length;
4        int sum = 0;
5
6        for (int k = 1; k * k <= n; k++)
7        {
8            if (n % k == 0)
9            {
10                if (IsSortable(nums, k))
11                {
12                    sum += k;
13                }
14
15                // if n/k is valid then also check n/(n/k)
16                if (k != n / k && IsSortable(nums, n/k))
17                {
18                    sum += n/k;
19                }
20            }
21        }
22
23        return sum;
24    }
25
26    public bool IsSortable(int[] nums, int k)
27    {
28        int n = nums.Length;
29        int prevMax = int.MinValue;
30
31        for (int i = 0; i < n; i += k)
32        {
33            int count = 0; // count of decending pairs in subarray
34            int min = nums[i];
35            int max = nums[i];
36
37            for (int j = i + 1; j < (i + k); j++)
38            {
39                if (nums[j] < nums[j-1]) count++;
40
41                min = Math.Min(min, nums[j]);
42                max = Math.Max(max, nums[j]);
43            }
44
45            // check cyclical (at most one decending pair) and each val is as at least as large as last subarray
46            if (count > 1 | min < prevMax) return false;
47            // check boundary
48            if (count == 1 & nums[i+k-1] > nums[i]) return false;
49            prevMax = max;
50        }
51
52        return true;
53    }
54}