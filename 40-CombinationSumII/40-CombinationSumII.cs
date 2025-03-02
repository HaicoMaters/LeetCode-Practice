public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        List<IList<int>> combinations = new List<IList<int>>();
        Array.Sort(candidates); // For stopping dupes
        CombinationSum2(candidates, target, 0, 0, new List<int>(), combinations);
        return combinations;
    }

    public void CombinationSum2(int[] candidates, int target, int currentVal, int start, List<int> combination, List<IList<int>> combinations)
    {
        if(currentVal == target)
        {
            combinations.Add(combination);
            return;
        }

        for (int i = start; i < candidates.Length; i++)
        {
            int candidate = candidates[i];
            if (i > start && candidates[i] == candidates[i - 1]) continue; // skip dupes
            if (currentVal + candidate <= target)
            {
                List<int> combo = new List<int>(combination);
                combo.Add(candidate);
                CombinationSum2(candidates, target, currentVal + candidate, i + 1, combo, combinations);
            }
        }
    }
}