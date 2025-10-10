// Last updated: 10/10/2025, 11:30:21
public class Solution {
    public int MaximumEnergy(int[] energy, int k) {
        int n = energy.Length;
        int[] maxGain = new int[n];
        int max = int.MinValue;
        
        for (int i = n-1; i >= 0; i--)
        {
            maxGain[i] = energy[i] + ((i + k < n) ? maxGain[i+k] : 0);
            max = Math.Max(max, maxGain[i]);
        }

        return max;
    }
}