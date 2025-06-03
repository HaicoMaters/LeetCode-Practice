// Last updated: 03/06/2025, 12:27:44
public class Solution {
    public int MaxCandies(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int[] initialBoxes) {
        int totalCandies = 0;
        int n = status.Length;

        bool[] hasKey = new bool[n]; // have key for box
        bool[] owned = new bool[n]; // owned boxes
        bool[] visited = new bool[n]; // visited boxes

        Queue<int> queue = new Queue<int>();

        // Add the initial owned boxes to queue
        foreach (int box in initialBoxes)
        {
            owned[box] = true;
            queue.Enqueue(box);
        }

        bool boxOpened = true;

        // BFS as long as one box is successfully opened in this round
        while (boxOpened)
        {
            boxOpened = false;

            for (int i = 0; i < queue.Count; i++)
            {
                int box = queue.Dequeue();
                if (!visited[box] && (status[box] == 1 || hasKey[box])) // visit unvisited open/unlockable boxes
                {
                    visited[box] = true;
                    boxOpened = true;

                    totalCandies += candies[box];

                    foreach (int key in keys[box]) // add all new visitable boxes from the keys found in the box
                    {
                        hasKey[key] = true;
                        if (owned[key] && !visited[key])
                        {
                            queue.Enqueue(key);
                        }
                    }

                    foreach (int contained in containedBoxes[box]) // Add the newly owned boxes to the queue
                    {
                        owned[contained] = true;
                        queue.Enqueue(contained);
                    }
                }
                else
                {
                    queue.Enqueue(box);
                }
            }
        }

        return totalCandies;
    }
}