// Last updated: 02/09/2025, 11:57:28
public class Solution {
    public char KthCharacter(int k) {
        StringBuilder sb = new StringBuilder("a");

        while (sb.Length < k)
        {
            StringBuilder next = new StringBuilder();
            for (int i = 0; i < sb.Length; i++)
            {
                char nextChar = (char)((sb[i] -'a' + 1) % 26 + 'a'); // make sure to clamp within range so we go z => a
                next.Append(nextChar);
            }
            sb.Append(next);
        }

        return sb[k-1];
    }
}