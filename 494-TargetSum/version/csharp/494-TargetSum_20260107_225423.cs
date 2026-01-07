// Last updated: 07/01/2026, 22:54:23
1public class Solution {
2    public int FindTargetSumWays(int[] nums, int target) {
3        // Dict for memoization, prevents O(2^n) possible combinations and make so O(n * sum(nums))
4        // The key is composed of start index and current value, if same start index and current value that means a result from that point
5        // has already been obtained e.g. start = 2 val = 2  (2 + 1 - 1) and (2 - 1 + 1) are the same and the combinations of + or - from
6        // That point will be the same as eachother so that means you can calc it once instead and just use the first number of combos
7        // from that point
8        Dictionary<(int, int), int> startVal = new Dictionary<(int, int), int>(); 
9        return BackTrack(nums, target, 0, 0, startVal);
10    }
11
12    public int BackTrack(int[] nums, int target, int currentVal, int index, Dictionary<(int, int), int> memo)
13    {
14         if (index == nums.Length) {
15            return currentVal == target ? 1 : 0;
16        }
17
18        if (memo.ContainsKey((index, currentVal))) {
19            return memo[(index, currentVal)];
20        }
21
22        int add = BackTrack(nums, target, currentVal + nums[index], index + 1, memo);
23        int subtract = BackTrack(nums, target, currentVal - nums[index], index + 1, memo);
24
25        memo[(index, currentVal)] = add + subtract;  // Store result
26        return memo[(index, currentVal)];
27    }
28}