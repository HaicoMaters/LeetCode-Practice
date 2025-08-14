// Last updated: 14/08/2025, 12:03:11
public class Solution {
    public string LargestGoodInteger(string num) {
        bool[] exists = new bool[10]; // index is repeated number i.e. 000 is index 0 and 999 is index 9
        int length = 1; // length of substring

        for (int i = 1; i < num.Length; i++)
        {
            if (num[i] == num[i-1])
            {
                length++;

                if (length == 3) exists[num[i] - '0'] = true;
            }
            else
            {
                length = 1;
            }
        }

        for (int i = 9; i >= 0; i--)
        {
            if (exists[i])
            {
                return $"{i}{i}{i}";
            }
        }
    

        return "";
    }
}