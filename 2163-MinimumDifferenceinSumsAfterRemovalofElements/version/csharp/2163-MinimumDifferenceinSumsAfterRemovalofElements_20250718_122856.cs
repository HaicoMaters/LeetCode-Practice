// Last updated: 18/07/2025, 12:28:56
public class Solution {
    public long MinimumDifference(int[] nums) {
        int n = nums.Length / 3;
        int l = nums.Length;
        long minDiff = long.MaxValue;

        long[] leftSum = new long[l];
        long[] rightSum = new long[l];

        var maxHeap = new PriorityQueue<int,int>();
        long sum = 0;

        for (int i = 0; i < 2 * n; i++) // Process the prefixes (Sum first)
        {
            maxHeap.Enqueue(nums[i], -nums[i]);
            sum += nums[i];

            if(maxHeap.Count > n)
            {
                sum -= maxHeap.Dequeue();
            }

            leftSum[i] = (maxHeap.Count == n) ? sum : long.MaxValue;
        }

        var minHeap = new PriorityQueue<int,int>();
        sum = 0;

        for (int i = l - 1; i >= n; i--) // Process the suffixes (Sum second)
        {
            minHeap.Enqueue(nums[i], nums[i]);
            sum += nums[i];

            if (minHeap.Count > n)
            {
                sum -= minHeap.Dequeue();
            }

            rightSum[i] = (minHeap.Count == n) ? sum : long.MinValue;
        }

        for (int i = n - 1; i < 2 * n; i++) // Calc the min difference
        {
            if (rightSum[i+1] != long.MinValue)
            {
                minDiff = Math.Min(minDiff, leftSum[i] - rightSum[i + 1]);
            }
        }

        return minDiff;
    }
}