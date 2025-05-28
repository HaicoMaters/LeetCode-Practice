// Last updated: 28/05/2025, 13:15:35
public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        int consecutiveOdds = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                consecutiveOdds = 0;               
            }
            else
            {
                consecutiveOdds++;
                if (consecutiveOdds == 3) return true;
            }
        }

        return false;
    }
}