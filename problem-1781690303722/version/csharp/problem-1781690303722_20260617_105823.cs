// Last updated: 17/06/2026, 10:58:23
1public class Solution {
2    public int[] FindArray(int[] pref) {
3        int[] arr = new int[pref.Length];
4        arr[0] = pref[0];
5        
6        for (int i = 1; i < arr.Length; i++)
7        {
8            arr[i] = pref[i-1] ^ pref[i];
9        }
10
11        return arr;
12    }
13}