// Last updated: 25/07/2025, 13:00:30
public class Solution {
    public int MaxSum(int[] nums) {
        int sum = 0;
        int max = int.MinValue; // for when all are negative
        HashSet<int> unique = new HashSet<int>(nums);

        foreach (int num in unique)
        {
            if (num > 0)
            {
                sum += num;
            }
            else
            {
                max = Math.Max(max, num);
            }
        }

        return sum > 0 ? sum : max;
    }
}