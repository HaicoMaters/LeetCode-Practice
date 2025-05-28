// Last updated: 28/05/2025, 13:14:43
public class Solution {
    public int[] GetOrder(int[][] tasks) {
        int n = tasks.Length;
        int[][] sortedTasks = new int[n][];

        // Store (original index, enqueue time, processing time)
        for (int i = 0; i < n; i++) {
            sortedTasks[i] = new int[] { i, tasks[i][0], tasks[i][1] };
        }

        // Sort by enqueue time
        Array.Sort(sortedTasks, (a, b) => a[1].CompareTo(b[1]));

        int time = 0;
        int nextTaskIndex = 0;
        int[] order = new int[n];
        int nextOrderIndex = 0;

        // Prio processing time then original index
        PriorityQueue<int, (int, int)> pq = new PriorityQueue<int, (int, int)>();

        void UpdatePossibleTasks() {
            if (nextTaskIndex >= n) return; // All tasks have been processed

            // Wait for next task
            if (pq.Count == 0 && sortedTasks[nextTaskIndex][1] > time) {
                time = sortedTasks[nextTaskIndex][1];
            }

            // Enqueue all tasks that can start now
            while (nextTaskIndex < n && sortedTasks[nextTaskIndex][1] <= time) {
                pq.Enqueue(sortedTasks[nextTaskIndex][0], (sortedTasks[nextTaskIndex][2], sortedTasks[nextTaskIndex][0]));
                nextTaskIndex++;
            }
        }

        UpdatePossibleTasks();

        while (pq.Count > 0) {
            int index = pq.Dequeue(); // Get original index
            order[nextOrderIndex++] = index; // Update order of tasks to complete

            time += tasks[index][1]; // Add time for task to complete

            UpdatePossibleTasks();
        }

        return order;
    }
}