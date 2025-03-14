public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        List<IList<int>> result = new List<IList<int>>();
        if (nums1.Length == 0 || nums2.Length == 0 || k == 0) return result;

        PriorityQueue<(int, int, int), int> minHeap = new PriorityQueue<(int, int, int), int>(); // num1 num2 sorted by sum

        // Insert first k pairs from nums1 into heap made with nums2[0] (sorted so only need first k)
        for (int i = 0; i < Math.Min(k, nums1.Length); i++) {
            minHeap.Enqueue((nums1[i], nums2[0], 0), nums1[i] + nums2[0]);
        }

        while (k > 0 && minHeap.Count > 0) {
            var (num1, num2, index) = minHeap.Dequeue();
            result.Add(new List<int> { num1, num2 });
            k--;

            // if there are more nums in nums2 enqueue possible pairs (can only happen k times due to while loop)
            if (index + 1 < nums2.Length) {
                minHeap.Enqueue((num1, nums2[index + 1], index + 1), num1 + nums2[index + 1]);
            }
        }

        return result;
    }
}