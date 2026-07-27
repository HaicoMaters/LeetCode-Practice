// Last updated: 27/07/2026, 09:33:02
1public class Solution {
2    public int MaxProduct(int[] nums) {
3        int largest = 0;
4        int secondLargest = 0;
5
6        for (int i = 0; i < nums.Length; i++)
7        {
8            int num = nums[i];
9            if(num > secondLargest)
10            {
11                if(num > largest)
12                {  
13                    secondLargest = largest;
14                    largest = num;
15                }
16                else
17                {
18                    secondLargest = num;
19                }
20            }
21        }
22
23        return (largest - 1) * (secondLargest -1);
24    }
25}