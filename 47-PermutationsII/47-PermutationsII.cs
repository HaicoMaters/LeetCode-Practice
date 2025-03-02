public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        List<IList<int>> permutations = new List<IList<int>>();
        Array.Sort(nums);
        PermuteUnique(nums, new List<int>(), permutations, new bool[nums.Length]);
        return permutations;
    }

    private void PermuteUnique(int[] nums, List<int> permutation, List<IList<int>> permutations, bool[] used)
    {
        if (permutation.Count == nums.Length)
        {
            permutations.Add(new List<int>(permutation));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i]) continue;
            if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1]) continue;

            used[i] = true;
            permutation.Add(nums[i]);
            PermuteUnique(nums, permutation, permutations, used);
            permutation.RemoveAt(permutation.Count - 1);
            used[i] = false;
        }
    }
}
