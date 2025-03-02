public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> subSets = new List<IList<int>>();
        subSets.Add(new List<int>()); // Add the empty set

        for (int i = 0; i < nums.Length; i++)
        {
            int totalSets = subSets.Count;
            // Add the next value of nums to the each set as a new subset
            for (int j = 0; j < totalSets; j++)
            {
                List<int> continuation = subSets[j].ToList();
                continuation.Add(nums[i]);
                subSets.Add(continuation);
            }
        }

        return subSets;
    }
}