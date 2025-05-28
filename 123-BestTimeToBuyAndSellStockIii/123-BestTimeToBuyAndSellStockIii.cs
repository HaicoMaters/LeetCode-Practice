// Last updated: 28/05/2025, 13:18:10
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length < 2) return 0;

        int n = prices.Length;
        
        // Find the best profit up until every day
        int minPrice = prices[0];
        int[] leftProfit = new int[n]; // Each index i is the day i

        for (int i = 1; i < n; i++) // Left to right -> best profit possible from past days
        {
            minPrice = Math.Min(minPrice, prices[i]);
            leftProfit[i] = Math.Max(leftProfit[i - 1], prices[i] - minPrice);
        }

        // Find the best profit from each day onwards
        int maxPrice = prices[n - 1];
        int[] rightProfit = new int[n];

        for (int i = n - 2; i >= 0; i--) // Right to left -> best profit possible in the future days
        {
            maxPrice = Math.Max(maxPrice, prices[i]);
            rightProfit[i] = Math.Max(rightProfit[i + 1], maxPrice - prices[i]);
        }

        int maxProfit = rightProfit[0];

        // Find the best combination to maximise profit
        for (int i = 0; i < n - 1; i++) 
        {
            maxProfit = Math.Max(maxProfit, leftProfit[i] + rightProfit[i + 1]);
        }

        return maxProfit;
    }
}
