public class Solution {
    public int MajorityElement(int[] nums) {
        int count = 0;
        int current = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                current = num;
            }
            if (num == current)
            {
                count++;
            }
            else
            {
                count--;
            }
        }
        return current;
    }
}