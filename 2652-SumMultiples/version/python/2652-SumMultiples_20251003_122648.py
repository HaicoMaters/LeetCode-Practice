# Last updated: 03/10/2025, 12:26:48
class Solution:
    def sumOfMultiples(self, n: int) -> int:
        sum = 0
        multiples = (3, 5, 7)

        for i in range(1, n + 1):
            for num in multiples:
                if i % num == 0:
                    sum += i
                    break

        return sum