// Last updated: 26/08/2025, 12:49:20
public class Solution {
    public int MaxFreqSum(string s) {
        int[] vowel = new int[26]; // split into two arrays for ease of getting max of each
        int[] cons = new int[26];
        HashSet<char> vowels = new HashSet<char>{'a', 'e' , 'i', 'o', 'u'};

        foreach (char c in s)
        {
            if (vowels.Contains(c))
            {   
                vowel[c - 'a']++;
            }
            else
            {
                cons[c - 'a']++;
            }
        }

        return vowel.Max() + cons.Max();
    }
}