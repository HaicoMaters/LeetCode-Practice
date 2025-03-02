public class Solution {
    public int HIndex(int[] citations) { 
        int length = citations.Length;
        int[] count = new int[length+1]; // each index i contains how many papers of that count exist

        foreach (int c in citations)
        {
            if (c >= length) // For bounds issues put all in the last index
            {
                count[length]++;
            }
            else
            {
                count[c]++; // update the count
            }
        }

        int total = 0;
        for (int i = length; i >= 0; i--) 
        // Go backwards until total exceeds or is total needed for that HIndex
        {
            total += count[i];
            if (total >= i) return i;
        }

        return 0;
    }
}