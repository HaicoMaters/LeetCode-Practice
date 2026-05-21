// Last updated: 21/05/2026, 11:11:02
1public class Solution {
2    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
3        int longestPrefix = 0;
4        HashSet<int> possiblePrefixes = new HashSet<int>();
5
6        for (int i = 0; i < arr1.Length; i++)
7        {
8            int num = arr1[i];
9
10            while (num > 0)
11            {
12                possiblePrefixes.Add(num);
13                num /= 10;
14            }
15        }
16
17        for (int j = 0; j < arr2.Length; j++)
18        {
19            int num = arr2[j];
20
21            while (num > 0)
22            {
23                if (possiblePrefixes.Contains(num))
24                {
25                    int length = num.ToString().Length;
26                    longestPrefix = Math.Max(longestPrefix, length);
27                }
28
29                num /= 10;
30            }
31        }
32
33        return longestPrefix;
34    }
35}