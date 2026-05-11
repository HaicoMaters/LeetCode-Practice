// Last updated: 11/05/2026, 08:03:45
1public class Solution {
2    public int[] SeparateDigits(int[] nums) {
3        List<int> digits = new List<int>();
4
5        foreach (int num in nums)
6        {
7            int size = digits.Count;
8            int x = num;
9            while (x > 0)
10            {
11                digits.Insert(size, x % 10); // insert at size to ensure rest of list is in order while digits are placed front to back (instead of back to front)
12                x /= 10;
13            }
14        }
15
16        return digits.ToArray();
17    }
18}