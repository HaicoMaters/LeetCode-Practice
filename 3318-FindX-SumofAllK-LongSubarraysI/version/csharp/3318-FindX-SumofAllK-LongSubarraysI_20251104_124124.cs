// Last updated: 04/11/2025, 12:41:24
public class Solution {
    public int[] FindXSum(int[] nums, int k, int x) {
        int n = nums.Length;
        int[] xSum = new int[n-k+1];

        for (int i = 0; i <= n - k; i++)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();

            for (int j = i; j < i + k; j++)
            {
                if (!freq.ContainsKey(nums[j]))
                {
                    freq[nums[j]] = 0;
                }
                freq[nums[j]]++;
            }

            List<(int num, int count)> counts = new List<(int,int)>();

            foreach (var kvp in freq)
            {
                counts.Add((kvp.Key, kvp.Value));
            }

            counts.Sort((a,b) => {
                if (b.count == a.count) return b.num.CompareTo(a.num);

                return b.count.CompareTo(a.count);
            });

            HashSet<int> bestKeys = new HashSet<int>();
            for (int j = 0; j < Math.Min(x, counts.Count); j++)
            {
                bestKeys.Add(counts[j].num);
            }

            int sum = 0;
            for (int j = i; j < i + k; j ++)
            {
                if(bestKeys.Contains(nums[j]))
                {
                    sum += nums[j];
                }
            }

            xSum[i] = sum;
        } 

        return xSum;
    }
}