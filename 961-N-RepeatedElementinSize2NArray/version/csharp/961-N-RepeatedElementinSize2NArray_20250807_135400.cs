// Last updated: 07/08/2025, 13:54:00
public class Solution {
    public int RepeatedNTimes(int[] nums) {
        HashSet<int> unique = new HashSet<int>();

        foreach (int num in nums)
        {
            if (unique.Contains(num)) return num; // n + 1 unique so only one repeated num
            unique.Add(num);
        }

        return -1;
    }
}