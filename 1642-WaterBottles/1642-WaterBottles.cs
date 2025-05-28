// Last updated: 28/05/2025, 13:14:49
public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int totalBottles = numBottles;
        int spareBottles = numBottles;

        while (spareBottles >= numExchange) {
            int newFullBottles = spareBottles / numExchange;
            totalBottles += newFullBottles;
            spareBottles = spareBottles % numExchange + newFullBottles;
        }

        return totalBottles;
    }
}
