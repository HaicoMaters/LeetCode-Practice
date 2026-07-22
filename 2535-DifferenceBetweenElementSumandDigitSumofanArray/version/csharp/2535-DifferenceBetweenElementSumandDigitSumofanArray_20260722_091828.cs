// Last updated: 22/07/2026, 09:18:28
1public class Solution {
2    public int DifferenceOfSum(int[] nums) {
3        int elementSum = 0;
4        int digitSum = 0;
5
6        foreach (int num in nums)
7        {
8            elementSum += num;
9
10            int sum = 0;
11            int x = num;
12
13            while (x > 0)
14            {
15                sum += x % 10;
16                x /= 10;
17            }
18
19            digitSum += sum;
20        }
21
22        return Math.Abs(elementSum - digitSum);
23    }
24}