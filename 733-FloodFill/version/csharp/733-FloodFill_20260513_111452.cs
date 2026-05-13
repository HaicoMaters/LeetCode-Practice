// Last updated: 13/05/2026, 11:14:52
1public class Solution {
2    int[][] dirs = new int[][]{new int[]{1,0}, new int[]{-1,0}, new int[]{0,1}, new int[]{0,-1}};
3
4    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
5        int m = image.Length;
6        int n = image[0].Length;
7        int originalCol = image[sr][sc];
8
9        if (color == originalCol) return image;
10
11        Queue<(int i, int j)> queue = new Queue<(int,int)>();
12        queue.Enqueue((sr,sc));
13        image[sr][sc] = color;
14
15        while (queue.Count > 0)
16        {
17            (int i, int j) = queue.Dequeue();
18
19            foreach(int[] dir in dirs)
20            {
21                int ni = i + dir[0];
22                int nj = j + dir[1];
23
24                if (ni >= 0 && ni < m && nj >= 0 && nj < n && image[ni][nj] == originalCol)
25                {
26                    queue.Enqueue((ni,nj));
27                    image[ni][nj] = color;
28                }
29            }
30        }
31        
32        return image;
33    }
34}