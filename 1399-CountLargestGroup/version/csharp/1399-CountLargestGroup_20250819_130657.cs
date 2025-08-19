// Last updated: 19/08/2025, 13:06:57
public class Solution {
    public int CountLargestGroup(int n) {
        Dictionary<int,int> groups = new Dictionary<int,int>();
        int max = 0;

        for (int i = 1; i <= n; i++)
        {
            int num = i;
            int digitSum = 0;

            while (num > 0)
            {
                digitSum += num % 10;
                num /= 10;
            }

            if (!groups.ContainsKey(digitSum))
            {
                groups[digitSum] = 0;
            }
            groups[digitSum]++;
            max = Math.Max(groups[digitSum], max);
        }

        return groups.Values.Count(x => x == max);
    }
}