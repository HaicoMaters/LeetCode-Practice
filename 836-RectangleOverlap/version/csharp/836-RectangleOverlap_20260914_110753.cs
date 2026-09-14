// Last updated: 14/09/2026, 11:07:53
1public class Solution {
2    public bool IsRectangleOverlap(int[] rec1, int[] rec2) {
3        if (rec2[0] >= rec1[2] || rec1[3] <= rec2[1] || 
4        rec2[2] <= rec1[0] || rec2[3] <= rec1[1]) return false;
5
6        return true;
7    }
8}