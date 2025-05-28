// Last updated: 28/05/2025, 13:14:47
public class Solution {
    public int LargestAltitude(int[] gain) {
        int highest = 0;
        int current = 0;

        for (int i = 0; i < gain.Length; i++){
            current += gain[i];
            if (current > highest) highest = current;
        }

        return highest;
    }
}