// Last updated: 18/12/2025, 16:52:59
1public class Solution {
2    public long MaxProfit(int[] prices, int[] strategy, int k) {
3        int n = prices.Length;
4
5        long[] profit = new long[n+1];
6        long[] priceSum = new long[n+1];
7
8        for (int i = 0; i < n; i++)
9        {
10            profit[i+1] = profit[i] + (long)prices[i] * strategy[i];
11            priceSum[i+1] = priceSum[i] + prices[i];
12        }
13
14        long maxProfit = profit[n];
15
16        for (int i = k - 1; i < n; i++)
17        {
18            long leftProfit = profit[i-k+1];
19            long rightProfit = profit[n] - profit[i+1];
20            long profitChange = priceSum[i+1] - priceSum[i-(k/2)+1];
21            maxProfit = Math.Max(maxProfit, leftProfit + rightProfit + profitChange);
22        }
23
24        return maxProfit;
25    }
26}