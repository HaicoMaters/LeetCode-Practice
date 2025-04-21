// Last updated: 21/04/2025, 16:09:42
public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        int n = score.Length;
        string[] ranks = new string[n];
        
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(); // index, score (negative)

        for (int i = 0; i < score.Length; i++)
        {
            pq.Enqueue(i, -score[i]);
        }

        if (pq.Count > 0)
        {
            ranks[pq.Dequeue()] = "Gold Medal";
        }

        if (pq.Count > 0)
        {
            ranks[pq.Dequeue()] = "Silver Medal";
        }

        if (pq.Count > 0)
        {
            ranks[pq.Dequeue()] = "Bronze Medal";
        }
    
        int index = 4;
        while (pq.Count > 0)
        {
            ranks[pq.Dequeue()] = $"{index}";
            index++;
        }

        return ranks;
    }
}