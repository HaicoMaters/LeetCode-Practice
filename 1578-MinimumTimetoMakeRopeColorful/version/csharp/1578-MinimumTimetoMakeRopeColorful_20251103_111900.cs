// Last updated: 03/11/2025, 11:19:00
public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        int minTime = 0;

        for (int i = 1; i < colors.Length; i++)
        {
            if(colors[i] == colors[i-1])
            {
                int time1 = neededTime[i-1];
                int time2 = neededTime[i];

                if (time1 <= time2)
                {
                    minTime += time1;
                    neededTime[i-1] = time2;
                }
                else
                {
                    minTime += time2;
                    neededTime[i] = time1;
                }
            }
        }

        return minTime;
    }
}