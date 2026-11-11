// Last updated: 11/11/2026, 12:17:51
1public class Solution {
2    public long MinimumCost(int cost1, int cost2, int costBoth, int need1, int need2) {
3        long a = (long)need1 * cost1 + (long)need2 * cost2; // buy all individually
4        long b = (long)Math.Max(need1, need2) * costBoth; // buy type 3 only
5
6        int min3 = Math.Min(need1, need2); // buy min possible type 3 items for one of two to be completely satisfied
7
8        // type3 for until smaller of need1 and need2, other type for the rest
9        long c = (long)min3 * costBoth + (long)(need1 - min3) * cost1 + (long)(need2 - min3) * cost2;
10
11        return Math.Min(a, Math.Min(b,c));
12    }
13}