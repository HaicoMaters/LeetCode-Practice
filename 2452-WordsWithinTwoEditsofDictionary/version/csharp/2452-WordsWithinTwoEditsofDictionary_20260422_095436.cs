// Last updated: 22/04/2026, 09:54:36
1public class Solution {
2    public IList<string> TwoEditWords(string[] queries, string[] dictionary) {
3        int n = queries[0].Length;
4        List<string> words = new List<string>();
5
6        foreach (string query in queries)
7        {
8            foreach (string word in dictionary)
9            {
10                int differentLetters = 0;
11                
12                for (int i = 0; i < n; i++)
13                {
14                    if(query[i] != word[i])
15                    {
16                        differentLetters++;
17
18                        if (differentLetters > 2) break;
19                    }
20                }
21                
22                if (differentLetters <= 2)
23                {
24                    words.Add(query);
25                    break;
26                }
27            }
28        }
29
30        return words;
31    }
32}