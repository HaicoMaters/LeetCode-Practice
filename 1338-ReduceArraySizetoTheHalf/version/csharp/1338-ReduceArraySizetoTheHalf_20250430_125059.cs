// Last updated: 30/04/2025, 12:50:59
public class Solution {
    public int MinSetSize(int[] arr) {
        int size = arr.Length;
        int half = size / 2;

        Dictionary<int, int> freq = new Dictionary<int, int>();
        
        foreach (int num in arr) 
        {
            if (!freq.ContainsKey(num)) 
            {
                freq[num] = 0;
            }
            freq[num]++;
        }

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

        foreach (int val in freq.Values) 
        {
            pq.Enqueue(val, -val);
        }

        int minSetSize = 0;

        while (size > half) 
        {
            size -= pq.Dequeue();
            minSetSize++;
        }

        return minSetSize;
    }
}