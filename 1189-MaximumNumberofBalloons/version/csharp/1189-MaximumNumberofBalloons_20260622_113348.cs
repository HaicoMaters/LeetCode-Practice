// Last updated: 22/06/2026, 11:33:48
1public class Solution {
2    public int MaxNumberOfBalloons(string text) {
3       int[] letters = new int[5]; // 0 -> b, 1 -> a, 2 -> l, 3 -> o, 4 -> n (just to avoid using something like a dict)
4
5       foreach (char c in text)
6       {
7            switch (c)
8            {
9                case 'b':
10                    letters[0]++;
11                    break;
12                case 'a':
13                    letters[1]++;
14                    break;
15                case 'l':
16                    letters[2]++;
17                    break;
18                case 'o':
19                    letters[3]++;
20                    break;
21                case 'n':
22                    letters[4]++;
23                    break;
24            }
25       }
26
27       int maxBalloons = Math.Min(Math.Min(letters[0], letters[1]), letters[4]); // the single occurances
28       maxBalloons = Math.Min(maxBalloons, Math.Min(letters[2] / 2, letters[3]/2)); // double occurances
29       return maxBalloons;
30    }
31}