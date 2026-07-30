// Last updated: 30/07/2026, 11:58:55
1public class Solution {
2    public int MinimumPushes(string word) {
3        int pushes = word.Length;
4
5        // 8 first 1, next 8 cost 2, next 8 cost 3, last ones cost 4
6        return pushes + Math.Max(pushes-8, 0) + Math.Max(pushes-16, 0) + Math.Max(pushes-24, 0); 
7    }
8}