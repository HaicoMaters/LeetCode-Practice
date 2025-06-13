// Last updated: 13/06/2025, 08:53:03
public class Solution {
    public int MinimizeMax(int[] nums, int p) {
        Array.Sort(nums);

        int left = 0; 
        int right = nums[^1] - nums[0]; // max diff

        while (left < right)
        {
            int mid = (right + left) / 2;
            int r = CountPairs(nums, mid); // count number of pairs that are less than mid (diff)

            if (r >= p)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }

    int CountPairs(int[] nums, int diff)
    {
        int pairs = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i+1] - nums[i] <= diff)
            {
                pairs++;
                i++;
            }
        }

        return pairs;
    }
}