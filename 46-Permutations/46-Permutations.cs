public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> permutations = new List<IList<int>>();
        
        Backtrack(permutations, new List<int>(), nums, new bool[nums.Length]);
        
        return permutations;
    }

        private void Backtrack(IList<IList<int>> permutations, IList<int> current, int[] nums, bool[] used) {
        if (current.Count == nums.Length) { 
            // If a complete permutation is formed, add it to the results
            permutations.Add(new List<int>(current));
            return;
        }

        for (int i = 0; i < nums.Length; i++) {
            if (used[i]) continue; // Skip numbers already included in the current permutation

            used[i] = true; // Update the current permutation
            current.Add(nums[i]); 

            Backtrack(permutations, current, nums, used); // Recursively build the next permutation

            current.RemoveAt(current.Count - 1); // Remove the last element to backtrack
            used[i] = false;
        }
    }   
}