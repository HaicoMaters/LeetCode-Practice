// Last updated: 30/10/2025, 10:28:06
public class Solution {
    public int MinNumberOperations(int[] target) {
        int operations = target[0];

        for (int i = 1; i < target.Length; i++)
        {
            operations += Math.Max(target[i] - target[i-1], 0);
        }

        return operations;
    }
}