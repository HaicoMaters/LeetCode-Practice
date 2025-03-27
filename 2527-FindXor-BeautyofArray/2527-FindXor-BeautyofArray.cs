// Last updated: 27/03/2025, 15:45:30
public class Solution {
    public int XorBeauty(int[] nums) {
        // The problem simplifies to XORing all the elements together.
        // This is because:
        // - For every triplet (i, j, k), the XOR-beauty boils down to XORing all numbers.
        // - The OR and AND operations don't matter due to the symmetry across all triplets.
        // - Each number appears equally in all three positions, making the result the same as XORing the entire array.

        int xorBeauty = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            xorBeauty ^= nums[i];
        }

        return xorBeauty;
    }
}