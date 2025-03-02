public class Solution {
    public uint reverseBits(uint n) {
        // Take the last bit from n and put at the end of reversed then continously shift
        uint reversed = 0;
        for (int i = 0; i < 32; i++)
        {
            reversed = reversed << 1; //Shift left
            reversed += n & 1; // Get last bit
            n = n >> 1; // Shift n right
        }
        return reversed;
    }
}