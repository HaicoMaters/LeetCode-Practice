// Last updated: 05/08/2025, 11:58:30
public class Solution {
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
        int n = fruits.Length;
        int unplacedFruitTypes = 0;
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (fruits[i] <= baskets[j])
                {
                    baskets[j] = 0;
                    break;
                }
            }
        }

        for (int x = 0; x < n; x++)
        {
            if (baskets[x] != 0) unplacedFruitTypes++;
        }

        return unplacedFruitTypes;
    }
}