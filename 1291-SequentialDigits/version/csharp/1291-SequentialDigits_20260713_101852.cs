// Last updated: 13/07/2026, 10:18:52
1public class Solution {
2    public IList<int> SequentialDigits(int low, int high) {
3        List<int> result = new List<int>();
4
5        for (int digit = 1; digit < 9; digit++)
6        {
7            // all nums 1 -> 9
8            int num = digit;
9            int next = num + 1;
10
11            // add the sequentail digit and add if within range
12            while (num <= high && next <= 9)
13            {
14                num = (num * 10) + next;
15                if (num >= low && num <= high) result.Add(num);
16
17                next++;
18            }
19        }
20
21        result.Sort();
22
23        return result;
24    }
25}