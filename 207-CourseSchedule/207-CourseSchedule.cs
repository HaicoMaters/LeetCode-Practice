public class Solution {
    // Kahn's Algorithm BFS solution
    public bool CanFinish(int numCourses, int[][] prerequisites) {

        // Build the graph and in-degree array
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        int[] inDegree = new int[numCourses];

        foreach (var prereq in prerequisites) {
            int course = prereq[0];
            int prerequisite = prereq[1];
            if (!graph.ContainsKey(prerequisite)) {
                graph[prerequisite] = new List<int>();
            }
            graph[prerequisite].Add(course);
            inDegree[course]++;
        }

        // Initialize the queue with all courses that have no prerequisites (in-degree 0)
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < numCourses; i++) {
            if (inDegree[i] == 0) {
                queue.Enqueue(i);
            }
        }

        // Process the courses in topological order (BFS)
        int processedCourses = 0;
        while (queue.Count > 0) {
            int course = queue.Dequeue();
            processedCourses++;

            // For each neighbor of the current course, reduce its in-degree
            if (graph.ContainsKey(course)) {
                foreach (var neighbor in graph[course]) {
                    inDegree[neighbor]--;
                    if (inDegree[neighbor] == 0) {
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }

        // If the number of processed courses is equal to the total number of courses, return true
        return processedCourses == numCourses;
    }
}