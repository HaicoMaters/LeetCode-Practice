// Last updated: 28/05/2025, 13:18:13
public class Solution {
    public int MaxProfit(int[] prices) { // Greedy solution focusing on the local possible profits
        int profit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i-1] < prices[i])
            {
                profit += prices[i] - prices[i-1];
            }
        }

        return profit;
    }
}