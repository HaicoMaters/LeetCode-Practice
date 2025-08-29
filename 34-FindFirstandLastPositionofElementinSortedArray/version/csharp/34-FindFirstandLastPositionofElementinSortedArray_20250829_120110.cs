// Last updated: 29/08/2025, 12:01:10
public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int left = BinSearch(nums, target, true);
        int right = BinSearch(nums, target, false);
        return new int[]{left, right};
    }

    public int BinSearch(int[] nums, int target, bool leftTarget)
    {
        int L = 0;
        int R = nums.Length -1;
        int mid = 0;
        int index = -1;

        while (L <= R)
        {
            mid = L + (R-L)/2;

            if (target > nums[mid])
            {
                L = mid + 1;
            }
            else if (target < nums[mid])
            {
                R = mid - 1;
            }
            else
            {
                index = mid;

                if (leftTarget)
                {
                    R = mid - 1;
                }
                else
                {
                    L = mid + 1;
                }
            }
        }
        return index;
    }
}