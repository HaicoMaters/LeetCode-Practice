public class Solution {
    public int[] Decode(int[] encoded, int first) {
        int n = encoded.Length + 1;
        int[] decoded = new int[n];
        decoded[0] = first;

        for (int i = 1; i < n; i++) {
            decoded[i] = encoded[i - 1] ^ decoded[i - 1];
        }

        return decoded;
    }
}
