// Last updated: 16/10/2025, 11:51:17
public class Solution {
    public int FindSmallestInteger(int[] nums, int value) {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            int rem = ((num % value) + value) % value;

            if (!freq.ContainsKey(rem))
            {
                freq[rem] = 0;
            }
            freq[rem]++;
        }

        int mex = 0;
        while (freq.ContainsKey(mex % value) && freq[mex % value] > 0)
        {
            freq[mex % value]--;
            mex++;
        }

        return mex;
    }
}