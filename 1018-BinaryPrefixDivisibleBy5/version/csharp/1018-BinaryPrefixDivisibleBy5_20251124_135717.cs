// Last updated: 24/11/2025, 13:57:17
public class Solution {
    public IList<bool> PrefixesDivBy5(int[] nums) {
        List<bool> div5 = new List<bool>();
        int mod = 0;

        foreach (int num in nums)
        {
            mod = (mod * 2 + num) % 5;
            div5.Add(mod == 0);
        }

        return div5;
    }
}