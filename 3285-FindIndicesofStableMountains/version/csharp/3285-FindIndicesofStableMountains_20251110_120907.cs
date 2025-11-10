// Last updated: 10/11/2025, 12:09:07
public class Solution {
    public IList<int> StableMountains(int[] height, int threshold) {
        List<int> stable = new List<int>();

        for(int i = 1; i < height.Length; i++)
        {
            if (threshold < height[i-1])
            {
                stable.Add(i);
            }
        }

        return stable;
    }
}