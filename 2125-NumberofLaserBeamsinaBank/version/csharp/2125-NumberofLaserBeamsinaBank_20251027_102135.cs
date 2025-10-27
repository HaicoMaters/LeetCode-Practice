// Last updated: 27/10/2025, 10:21:35
public class Solution {
    public int NumberOfBeams(string[] bank) {
        int beams = 0;
        int deviceCount = 0;

        foreach (string row in bank)
        {
            int count  = 0;

            foreach (char c in row)
            {
                if (c == '1') count++;
            }

            if (count > 0)
            {
                beams += deviceCount * count;
                deviceCount = count;
            }
        }

        return beams;
    }
}