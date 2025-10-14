// Last updated: 14/10/2025, 11:46:00
public class Solution {
    public bool HasIncreasingSubarrays(IList<int> nums, int k) {
        int curLength = 1;
        int prevLength = 0;

        for (int i = 1; i < nums.Count; i++)
        {
            if (nums[i-1] < nums[i])
            {
                curLength++;
            }
            else
            {
                prevLength = curLength;
                curLength = 1;
            }

            if ((curLength >= k * 2) || (curLength >= k && prevLength >= k))
            {
                return true;
            }
        }

        return false;
    }
}