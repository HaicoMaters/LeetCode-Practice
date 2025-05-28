// Last updated: 28/05/2025, 13:15:31
public class Solution {
    public int BalancedStringSplit(string s) { // Only inputs are L or R
        int balance = 0;
        int substrings = 0;
        foreach (char c in s){
            if (c == 'L'){
                balance++;
            }
            else{
                balance--;
            }

            if (balance == 0) substrings++;
        }

        return substrings;
    }
}