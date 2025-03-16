public class Solution {
    public char FindTheDifference(string s, string t) {
        Dictionary<char, int> frequencies = new Dictionary<char, int>();

        foreach (char c in s){
            if(!frequencies.ContainsKey(c)){
                frequencies[c] = 1;
            }
            else{
                frequencies[c]++;
            }
        }
        
        foreach (char c in t)
        {
            if (!frequencies.ContainsKey(c) || frequencies[c] == 0){
                return c;
            }
            frequencies[c]--;
        }

        return 'f';
    }
}