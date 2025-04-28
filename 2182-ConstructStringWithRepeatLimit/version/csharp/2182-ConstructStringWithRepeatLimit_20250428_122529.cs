// Last updated: 28/04/2025, 12:25:29
public class Solution {
    public string RepeatLimitedString(string s, int repeatLimit) {
        int[] freq = new int[26];

        for(int i=0; i<s.Length; i++)
        {
            freq[s[i] - 'a']++;
        }

        StringBuilder sb = new StringBuilder();
        
        for(int i=25; i>=0; i--)
        {
            int pos = i;
            int limit = Math.Min(freq[pos], repeatLimit);

            for(int j=0; j<limit; j++)
            {
                sb.Append((char)((pos) + 'a'));
                freq[pos]--;
            }

            if(freq[pos] >= 1)
            {                
                pos--;

                while (pos >= 0 && freq[pos] == 0) 
                {
                    pos--;
                }

                if (pos < 0) break; 
                
                sb.Append((char)((pos) + 'a'));
                freq[pos]--;
                i++;
            }
        }

        return sb.ToString();
        
    }
}