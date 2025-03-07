public class Solution {
    public string GetHint(string secret, string guess) {
        Dictionary<char, int> secretCount = new Dictionary<char, int>();

        int x = 0;
        int y = 0;

        foreach (char c in secret){
            if(secretCount.ContainsKey(c)){
                secretCount[c]++;
            }
            else{
                secretCount[c] = 1;
            }
        }

        for (int i = 0; i < guess.Length; i++){
            char c = guess[i];
            if (secretCount.ContainsKey(c) && secretCount[c] > 0){
                y++;
                secretCount[c]--;
            }
            if (c == secret[i]){
                y--;
                x++;
            }
        }

        return string.Concat(x,"A", y,"B");
    }
}