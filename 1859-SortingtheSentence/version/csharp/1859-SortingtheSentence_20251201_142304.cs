// Last updated: 01/12/2025, 14:23:04
1public class Solution {
2    public string SortSentence(string s) {
3        string[] sentence = s.Split(' ');
4        string[] sortedSentence = new string[sentence.Length];
5
6        foreach (string part in sentence)
7        {
8            int index = part[part.Length - 1] - '0' - 1; 
9            sortedSentence[index] = part.Substring(0, part.Length - 1);
10        }
11
12        return String.Join(' ', sortedSentence);
13    }
14}