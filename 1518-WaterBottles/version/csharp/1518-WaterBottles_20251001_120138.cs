// Last updated: 01/10/2025, 12:01:38
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
