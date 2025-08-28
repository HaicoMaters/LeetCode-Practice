// Last updated: 28/08/2025, 11:52:07
public class Solution {
    public int ScoreOfString(string s) {
        int score = 0;

        for (int i = 1; i < s.Length; i++)
        {
            score += Math.Abs(s[i-1] - s[i]);
        }

        return score;
    }
}