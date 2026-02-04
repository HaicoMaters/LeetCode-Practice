// Last updated: 04/02/2026, 13:55:00
1public class Solution {
2    public int CountTriplets(int[] arr) {
3        int n = arr.Length;
4        int[] pre = new int[n+1];
5
6        for (int i = 0; i < n; i++)
7        {
8            pre[i+1] = pre[i] ^ arr[i];
9        }
10
11        int triplets = 0;
12        for (int i = 0; i < n; i++)
13        {
14            for (int j = i + 1; j < n; j++)
15            {
16                if (pre[i] == pre[j+1])
17                {
18                    triplets += (j - i);
19                }
20            }
21        }
22
23        return triplets;
24    }
25}