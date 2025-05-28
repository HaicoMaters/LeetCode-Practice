// Last updated: 28/05/2025, 13:14:13
public class Solution {
    public int MinimumIndex(IList<int> nums) {
        int dominantNumber = -1;
        int dominance = 0;

         foreach(int num in nums)
        {
            if(dominance == 0)
            {
                dominantNumber = num;
                dominance++;
            }
            else
            {
                dominance += (num == dominantNumber) ?  1 : -1;
            }
        }

        int dominantCount = 0;
        foreach (int num in nums)
        {
            if (num == dominantNumber)
                dominantCount++;
        }

        int dominantSeen = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            if(nums[i] == dominantNumber)
            {
                dominantSeen++;
                if(2 * dominantSeen > i + 1 && 2 * (dominantCount - dominantSeen) > nums.Count - i - 1)
                {
                    return i;
                }
            }
        }

        return -1;
    }
}