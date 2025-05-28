// Last updated: 28/05/2025, 13:16:09
public class Solution {
    public string ToLowerCase(string s) {
        var str = new StringBuilder();
        for(int i = 0; i < s.Length; i++) 
        {
            int ascii = (int)s[i];
            if(ascii >= 65 && ascii <= 90) 
            { // Check if upper or lower Upper is 65 to 90 and lower is 97 to 122 a diff of 32
                ascii += 32;
                char a = (char)ascii;
                str.Append(a);
            } 
            else 
            {
                char a = (char)ascii;
                str.Append(a);
            }
        }
        return str.ToString();
    }
}