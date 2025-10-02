# Last updated: 02/10/2025, 10:53:38
class Solution:
    def maxBottlesDrunk(self, numBottles: int, numExchange: int) -> int:
        totalBottles = numBottles
        spareBottles = numBottles

        while (spareBottles >= numExchange):
            spareBottles -= numExchange
            numExchange += 1
            spareBottles += 1
            totalBottles += 1

        return totalBottles