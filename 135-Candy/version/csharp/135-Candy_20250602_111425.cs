// Last updated: 02/06/2025, 11:14:25
public class Solution {
    public int Candy(int[] ratings) { // More efficent greedy solution
       int n = ratings.Length;
        int[] candies = new int[n];
        
        // Give every child 1 candy initially
        for (int i = 0; i < n; i++) 
        {
            candies[i] = 1;
        }

        // Left to right pass
        for (int i = 1; i < n; i++) 
        {
            if (ratings[i] > ratings[i - 1])
            {
                candies[i] = candies[i - 1] + 1;
            }
        }

        // Right to left pass
        for (int i = n - 2; i >= 0; i--) 
        {
            if (ratings[i] > ratings[i + 1]) 
            {
                candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
            }
        }

        // Sum all candies
        return candies.Sum();
    }
}