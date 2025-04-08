// Last updated: 08/04/2025, 17:18:08
public class Solution {
    public int PoorPigs(int buckets, int minutesToDie, int minutesToTest) {
        int possibleTests = minutesToTest / minutesToDie; // rounds down correctly        
        int pigs = 0;

        while (Math.Pow(possibleTests + 1, pigs) < buckets) // T + 1 states each pig can be in
        {
            pigs++;
        }


        return pigs;
    }
}