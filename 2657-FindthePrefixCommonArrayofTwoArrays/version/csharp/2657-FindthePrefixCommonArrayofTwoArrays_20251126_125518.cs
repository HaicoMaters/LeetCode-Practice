// Last updated: 26/11/2025, 12:55:18
1public class Solution {
2    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
3        int n = A.Length;
4
5        bool[] seen = new bool[n+1]; // nums 1 => n + 1 inclusive
6        int[] prefixArr = new int[n];
7
8        int sameCount = 0;
9
10        for (int i = 0; i < n; i++)
11        {
12            if (seen[A[i]])
13            {
14                sameCount++;
15            }
16            else
17            {
18                seen[A[i]] = true;
19            }
20
21            if (seen[B[i]])
22            {
23                sameCount++;
24            }
25            else
26            {
27                seen[B[i]] = true;
28            }
29
30            prefixArr[i] = sameCount;
31        }
32
33        return prefixArr;
34    }
35}