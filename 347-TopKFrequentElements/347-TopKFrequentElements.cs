public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        var frequencies = new Dictionary<int, int>();
        int[] elements = new int[k];

        // Get frequency of each number
        foreach (int num in nums){
            if (frequencies.ContainsKey(num)){
                frequencies[num]++;
            }
            else{
                frequencies.Add(num, 1);
            }
        }

        PriorityQueue<int, int> pq = new PriorityQueue<int,int>(); // priority is -frequency
        
        // Add to Queue
        foreach(var kvp in frequencies){
            pq.Enqueue(kvp.Key, -kvp.Value);
        }

        // Dequeue k most frequent elements from the queue
        for (int i = 0; i < k; i++){
            elements[i] = pq.Dequeue();
        }

        return elements;

    }
}