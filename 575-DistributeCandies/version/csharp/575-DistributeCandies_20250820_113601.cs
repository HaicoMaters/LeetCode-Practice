// Last updated: 20/08/2025, 11:36:01
public class Solution {
    public int DistributeCandies(int[] candyType) {
        Dictionary<int,int> freq = new Dictionary<int,int>();

        foreach (int candy in candyType)
        {
            if (!freq.ContainsKey(candy))
            {
                freq[candy] = 0;
            }
            freq[candy]++;
        }

        int canEatMax = candyType.Length/2; // if atleast n/2 different types
        return Math.Min(canEatMax, freq.Count);
    }
}