// Last updated: 21/07/2025, 10:52:11
public class Solution {
    public string MakeFancyString(string s) {
        bool twoConsec = false;
        char last = '0'; // only consists of lowercase english letters so can just initalize as this

        StringBuilder sb = new StringBuilder();

        foreach (char c in s)
        {
            if (c == last)
            {
                if (!twoConsec)
                {
                    twoConsec = true;
                    sb.Append(c);
                }
            }
            else
            {
                last = c;
                twoConsec = false;
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}