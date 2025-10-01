# Last updated: 01/10/2025, 13:43:08
class Solution:
    def numWaterBottles(self, numBottles: int, numExchange: int) -> int:
        totalBottles = numBottles
        spareBottles = numBottles

        while (spareBottles >= numExchange):
            newFullBottles = spareBottles // numExchange
            totalBottles += newFullBottles
            spareBottles = spareBottles % numExchange + newFullBottles

        return totalBottles
        