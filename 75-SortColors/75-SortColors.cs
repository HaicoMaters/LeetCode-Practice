public class Solution {
    public void SortColors(int[] nums) {
        int redCount = 0;
        int whiteCount = 0;
        // Aasuming constraints met no need for blue count

        for (int i = 0; i < nums.Length; i++)
        {
            switch (nums[i])
            {
                case 0:
                    redCount++;
                    break;
                case 1:
                    whiteCount++;
                    break;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if(redCount > 0)
            {
                nums[i] = 0;
                redCount--;
            }
            else if(whiteCount > 0)
            {
                nums[i] = 1;
                whiteCount--;
            }
            else{
                nums[i] = 2;
            }
        }

        return;
    }
}