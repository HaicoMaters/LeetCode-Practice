// Last updated: 09/09/2025, 13:22:56
public class Solution {
    public int PeopleAwareOfSecret(int n, int delay, int forget) {
        int mod = 1000000007;

        long[] dp = new long[n + 1]; // nums of people who know secret on each day
        dp[1] = 1;

        long share = 0; // people who can share secret on curr day

        for (int day = 2; day <= n; day++)
        {
            // add people who have had secret shared with them
            if (day - delay >= 1)
            {
                share = (share + dp[day-delay]) % mod;
            }
            // remove people who forget secret this day
            if (day - forget >= 1)
            {
                share = (share - dp[day - forget] + mod) % mod;
            }
            dp[day] = share;
        }

        // count all who remember at last day
        long people = 0;
        for (int day = n - forget + 1; day <= n; day++)
        {
            if (day >= 1)
            {
                people = (people + dp[day]) % mod;
            }
        }

        return (int) people;
    }
}