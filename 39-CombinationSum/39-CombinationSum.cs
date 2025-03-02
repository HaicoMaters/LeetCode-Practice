public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        List<IList<int>> combinations = new List<IList<int>>();
        CombinationSum(candidates, target, 0, 0, new List<int>(), combinations);
        return combinations;
    }

    public void CombinationSum(int[] candidates, int target, int currentVal, int start, List<int> combination, List<IList<int>> combinations)
    {
        if(currentVal == target)
        {
            combinations.Add(combination);
            return;
        }

        for (int i = start; i < candidates.Length; i++)
        {
            int candidate = candidates[i];
            if (currentVal + candidate <= target)
            {
                List<int> combo = new List<int>(combination);
                combo.Add(candidate);
                CombinationSum(candidates, target, currentVal + candidate, i, combo, combinations);
            }
        }
    }
}