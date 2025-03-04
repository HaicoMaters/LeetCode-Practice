public class Solution {
    public int Candy(int[] ratings) {
        
        // if 0 always 1 candy if 1 either 1 or 2 candy if 2 -> 1 - 3 candy
        // Max Candy for each kid is prio + 1
        // in case 3 2 1 0 need 4 + 3 + 2 + 1 while in case 0 3 1 2 need 1 + 2 + 1 + 2
        // Priority queue based on ratings then can see left and right value
        int n = ratings.Length;

        if(n == 1) return 1;

        int[] candy = new int[n];
        int total = 0;
        var pq = new PriorityQueue<int, int>(); // Index then rating
        
        // Get each rating of each kid in a priority queue;
        for (int i = 0; i < n; i++)
        {
            pq.Enqueue(i, ratings[i]);
        }
        
        for (int i = 0; i < n; i++)
        {
            int index = pq.Dequeue();
            int amount = 0;
            // Handle index = 0, and index = n - 1 first always 1 if same or lower priority of neighbour or neighbour + 1 if higher
            if (index == 0)
            {
                amount = (ratings[index] > ratings[index + 1]) ? candy[index + 1] + 1 : 1;
                total += amount;
                candy[index] = amount;
            }
            else if (index == n - 1)
            {
                amount = (ratings[index] > ratings[index - 1]) ? candy[index - 1] + 1 : 1;
                total += amount;
                candy[index] = amount;
            }
            else
            {
                // Lower or same prio than both
                if (ratings[index] <= ratings[index - 1] && ratings[index] <= ratings[index + 1])
                {
                    amount = 1;
                }
                // Higher prio than both
                else if (ratings[index] > ratings[index - 1] && ratings[index] > ratings[index + 1])
                {
                    amount = Math.Max(candy[index - 1], candy[index + 1]) + 1;
                }
                // Higher prio than left only
                else if (ratings[index] > ratings[index - 1])
                {
                    amount = candy[index - 1] + 1;
                }
                // Higher prio than right only
                else
                {
                    amount = candy[index + 1] + 1;
                }

                total += amount;
                candy[index] = amount;
            }
        }

        return total;
    }
}