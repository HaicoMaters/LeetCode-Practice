public class Solution {
    public string GetPermutation(int n, int k) {

        // Notes: My logic to attempt a soulution mathematically working kind of backwards

        // So for n being 4 there are permutaiton 1-4 begining the sequence
        // when starting with 1 there are 3 * 2 * 1 = possible ways that the numbers behind are sequenced so when it starts with 
        // 2 then it will be the seventh permutation for 2134 and 8 will be 2143 and 9 will be 2314
        // so +6 for every new starting digit then +2 for every second digit and + 1 for every change to the last digit
        // this is a similar pattern to 3 * 2 * 1 but then get rid of the 3 from the equation and do 2 * 1 for the first fixed
        // digit
        // So if you want 2431 it is (1 + 6) for the first digit + 2 + 2 (to move twice to get the 4) and then + 1 to swap the 1 
        // to the end and then with one more +1 it will be 3124

        // Get all chars used
        List<char> chars = new List<char>();
        int[] factors = new int[n]; // Index of char compared to how many permuations to affect
        for (int i = 0; i < n; i++)
        {
            chars.Add((char)((i+1) + '0'));
            int temp = (n - 1) - i;
            factors[i] = temp;
            while (temp > 1) // Check the factors calc for issues if found
            {
                temp--;
                factors[i] *= temp;
            }
        }
        factors[n - 1] = 0; // The Last Space Does not effect anything

        if (k == 1) return new string(chars.ToArray());

        for (int i = 0; i < n - 1; i ++) // Skip the last digit as factor is zero and cannot change anything
        {
            int count = 0;
            int currentFactor = factors[i];
            while ((k) > currentFactor)
            {
                k-= currentFactor;
                count++;
            }

            // Rearrange the string so that the value at count is appropriately moved so if 1 is replaced with 3 on first go
            // it is 3124 not 3214 so keep order the same but insert at i and move all back after pos i
            char charToMove = chars[i + count];
            chars.RemoveAt(i + count);
            chars.Insert(i, charToMove);
        }


        return new string(chars.ToArray());
    }
}