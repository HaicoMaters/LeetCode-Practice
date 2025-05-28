// Last updated: 28/05/2025, 13:15:48
public class Solution {
    public int MincostTickets(int[] days, int[] costs) {
        
        int finalDay = days[days.Length - 1];
        bool[] daysTravelled = new bool[finalDay + 1];

        // Add the days that are travelled on
        foreach (int day in days)
        {
            daysTravelled[day] = true;
        }

        // The Total cost up to specific day
        int[] totalCost = new int[finalDay + 1];
        totalCost[0] = 0;

        for (int i = 1; i <= finalDay; i++) // Final Day Inclusive
        {
            // Price of day not travelled on is the same as price of day before
            if (!daysTravelled[i])
            {
                totalCost[i] = totalCost[i - 1];
                continue;
            }

            // Add price of if using 1 day ticket
            totalCost[i] = costs[0] + totalCost[i - 1];
            
            // Make the cheapest of using 7 day ticket from 7 days ago (or has far back as possible) or multiple 1 day tickets
            totalCost[i] = Math.Min(totalCost[i] , totalCost[Math.Max(0, i-7)] + costs[1]);

            // Do the same but now for a 30 day ticket
            totalCost[i] = Math.Min(totalCost[i], totalCost[Math.Max(0, i-30)] + costs[2]);
        }

        return totalCost[finalDay];
    }
}