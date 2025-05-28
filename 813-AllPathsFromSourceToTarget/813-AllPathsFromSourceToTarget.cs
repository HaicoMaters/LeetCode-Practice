// Last updated: 28/05/2025, 13:15:58
public class Solution {
    List<IList<int>> paths;

    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        paths = new List<IList<int>>();
        DFS(graph, 0, new List<int>());
        return paths;
    }

    public void DFS(int[][] graph, int index, List<int> path)
    {
        path.Add(index);

        if (index == graph.Length-1)
        {
            paths.Add(new List<int>(path));
            path.RemoveAt(path.Count-1);
            return;
        }

        for (int i = 0; i < graph[index].Length; i++)
        {
            DFS(graph, graph[index][i], path);
        }

        path.RemoveAt(path.Count-1);
    }
}