// Last updated: 17/12/2025, 17:34:56
1public class Solution {
2    long[,,] memo;
3    public long MaximumProfit(int[] prices, int k) {
4        int n = prices.Length;
5        memo = new long[n,k+1,3]; // 3 states (0 -> no open transaction, 1 -> holding normal position, 2 -> holding short position)
6
7        for (int i = 0; i < n; i++)
8        {
9            for (int j = 0; j < k + 1; j++)
10            {
11                for (int state = 0; state < 3; state++)
12                {
13                    memo[i, j, state] = -1;
14                }
15            }
16        }
17
18        return DFS(n-1, k, 0, prices);
19    }
20
21    long DFS(int i, int j, int state, int[] prices)
22    {
23        if (j == 0) return 0;
24
25        if (i == 0)
26        {
27            // handle transaction type/state
28            return (state == 0) ? 0 : (state == 1 ? -prices[0] : prices[0]);
29        }
30
31        // memoization step
32        long profit = memo[i, j, state];
33        if (profit != -1) return profit;
34
35        int price = prices[i];
36
37        switch (state)
38        {
39            case 0: // explore staying idle, selling normal transaction and buying back short transaction
40                profit = Math.Max(DFS(i-1, j, 0, prices), Math.Max(DFS(i-1, j, 1, prices) + price, DFS(i-1, j, 2, prices) - price));
41                break;
42            case 1: // explore keep holding or opening new normal transaction
43                profit = Math.Max(DFS(i-1, j, 1, prices), DFS(i-1, j-1, 0, prices) - price);
44                break;
45            case 2: // explore keep holding or opening new short transaction
46                profit = Math.Max(DFS(i-1, j, 2, prices), DFS(i-1, j-1, 0, prices) + price);
47                break;
48        }
49
50        memo[i,j,state] = profit;
51        return profit;
52    }
53}