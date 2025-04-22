// Last updated: 22/04/2025, 12:59:33
public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        PriorityQueue<int, (int distance, int value)> pq = new PriorityQueue<int, (int, int)>(); // handle ties with value

        foreach (int element in arr)
        {
            pq.Enqueue(element, (Math.Abs(element - x), element));
        }

        List<int> elements = new List<int>();
        for (int i = 0; i < k; i++)
        {
            elements.Add(pq.Dequeue());
        }

        elements.Sort();
        return elements;
    }
}