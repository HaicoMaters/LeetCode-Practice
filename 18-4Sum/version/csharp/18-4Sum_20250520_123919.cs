// Last updated: 20/05/2025, 12:39:19
public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        int n = nums.Length;
        List<IList<int>> combinations = new List<IList<int>>();

        if (n < 4) return combinations; 
        Array.Sort(nums);

        for (int i = 0; i < n-3; i++)
        {
            if (i > 0 && nums[i] == nums[i-1]) continue; // skip duplicates (starting with same i val)

            for (int j = i+1; j < n - 2; j++)
            {
                if(j > i + 1 && nums[j] == nums[j-1]) continue; // skip duplicates (starting with same j val)

                int l = j + 1;
                int r = n-1;

                long targetSum = (long) target - nums[i] - nums[j]; // long avoid overflow

                while(l < r)
                {
                    long sum = (long)nums[l] + nums[r];
                    if (sum == targetSum)
                    {
                        combinations.Add(new List<int> {nums[i],nums[j],nums[l],nums[r]});
                        while (l < r && nums[l] == nums[l + 1]) l++; // Skip duplicates (starting with same l val)
                        while (l < r && nums[r] == nums[r - 1]) r--; // Skip duplicates (starting with same r val)
                        l++;
                        r--;
                    }
                    else if (sum < targetSum) l++;
                    else r--;
                }
            }
        }

        return combinations;
    }
}