// Last updated: 19/06/2026, 11:52:34
1public class Solution {
2    public int LargestAltitude(int[] gain) {
3        int highest = 0;
4        int current = 0;
5
6        for (int i = 0; i < gain.Length; i++){
7            current += gain[i];
8            if (current > highest) highest = current;
9        }
10
11        return highest;
12    }
13}