// Last updated: 12/05/2025, 12:00:19
public class Solution {
    public int[] FindEvenNumbers(int[] digits) {
        HashSet<int> even = new HashSet<int>();

        int n = digits.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n;  j++)
            {
                for (int k = 0; k < n; k++)
                {
                    // Skip using dupes, non even, or less than 100 (digits[i] is 0)
                    if (i == j || i == k || j == k || digits[k] % 2 != 0 || digits[i] == 0)
                    {
                        continue;
                    }

                    even.Add(digits[i] * 100 + digits[j] * 10 + digits[k]);
                }
            }
        }
         
        List<int> result = even.ToList();
        result.Sort();
        return result.ToArray();
    }
}