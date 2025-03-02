public class Solution {
    public int MaxProduct(int[] nums) {
        int largest = 0;
        int secondLargest = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            if(num > secondLargest)
            {
                if(num > largest)
                {  
                    secondLargest = largest;
                    largest = num;
                }
                else
                {
                    secondLargest = num;
                }
            }
        }

        return (largest - 1) * (secondLargest -1);
    }
}