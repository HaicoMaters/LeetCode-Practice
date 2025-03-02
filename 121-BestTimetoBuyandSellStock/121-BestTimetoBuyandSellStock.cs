public class Solution {
    public int MaxProfit(int[] prices) {
        // Two Pointer Solution
        if (prices == null || prices.Length < 2) return 0;

        int profit = 0;
        int L = 0; // Buy
        int R = 1; //Sell

        while (R < prices.Length)
        {
            int buy = prices[L];
            int sell = prices[R];
            if (buy < sell) profit = Math.Max(profit, sell - buy);
            else L = R; // New Lowest Buy Price For Future Comparisions if there is a lower sell price from that point
            R++;
        }

        return profit;
    }
}