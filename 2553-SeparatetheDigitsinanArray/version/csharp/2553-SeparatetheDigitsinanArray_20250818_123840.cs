// Last updated: 18/08/2025, 12:38:40
public class Solution {
    public int[] SeparateDigits(int[] nums) {
        List<int> digits = new List<int>();

        foreach (int num in nums)
        {
            int size = digits.Count;
            int x = num;
            while (x > 0)
            {
                digits.Insert(size, x % 10); // insert at size to ensure rest of list is in order while digits are placed front to back (instead of back to front)
                x /= 10;
            }
        }

        return digits.ToArray();
    }
}