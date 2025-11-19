// Last updated: 19/11/2025, 12:17:54
public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        HashSet<int> vals = new HashSet<int>(nums);

        while (vals.Contains(original))
        {
            original *= 2;
        }

        return original;
    }
}