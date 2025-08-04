// Last updated: 04/08/2025, 10:52:24
public class Solution {
    public int TotalFruit(int[] fruits) {
        int basket1 = -1;
        int basket1Count = 0;
        int basket2 = -1;
        int basket2Count = 0;
        int max = 0;

        foreach (int fruit in fruits)
        {
            if (basket1 == -1)
            {
                basket1 = fruit;
                basket1Count = 1;
            }
            else if (basket1 == fruit)
            {
                basket1Count++;
            }
            else if (basket2 == fruit)
            {
                basket2 = basket1;
                basket2Count += basket1Count;
                basket1 = fruit;
                basket1Count = 1;
            }
            else // start new basket
            {
                basket2 = basket1;
                basket2Count = basket1Count;
                basket1 = fruit;
                basket1Count = 1;
            }
            
            max = Math.Max(max, basket1Count + basket2Count);
        }

        return max;
    }
}