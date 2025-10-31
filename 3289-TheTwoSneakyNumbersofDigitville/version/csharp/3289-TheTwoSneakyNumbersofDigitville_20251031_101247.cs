// Last updated: 31/10/2025, 10:12:47
public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        int[] sneakyNums = new int[2];

        int n = nums.Length - 2;
        bool[] seen = new bool[n];
        bool pair1 = true;

        foreach (int num in nums)
        {
            if (seen[num])
            {
                if(pair1)
                {
                    pair1 = false;
                    sneakyNums[0] = num;
                }
                else
                {
                    sneakyNums[1] = num;
                    return sneakyNums;
                }
            }

            seen[num] = true;
        }

        return sneakyNums;
    }
}