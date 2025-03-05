public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {
        // Dict for memoization, prevents O(2^n) possible combinations and make so O(n * sum(nums))
        // The key is composed of start index and current value, if same start index and current value that means a result from that point
        // has already been obtained e.g. start = 2 val = 2  (2 + 1 - 1) and (2 - 1 + 1) are the same and the combinations of + or - from
        // That point will be the same as eachother so that means you can calc it once instead and just use the first number of combos
        // from that point
        Dictionary<(int, int), int> startVal = new Dictionary<(int, int), int>(); 
        return BackTrack(nums, target, 0, 0, startVal);
    }

    public int BackTrack(int[] nums, int target, int currentVal, int index, Dictionary<(int, int), int> memo)
    {
         if (index == nums.Length) {
            return currentVal == target ? 1 : 0;
        }

        if (memo.ContainsKey((index, currentVal))) {
            return memo[(index, currentVal)];
        }

        int add = BackTrack(nums, target, currentVal + nums[index], index + 1, memo);
        int subtract = BackTrack(nums, target, currentVal - nums[index], index + 1, memo);

        memo[(index, currentVal)] = add + subtract;  // Store result
        return memo[(index, currentVal)];
    }
}