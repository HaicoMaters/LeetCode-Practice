// Last updated: 28/05/2026, 09:40:32
1public class Solution {
2    public class TrieNode {
3        public TrieNode[] next = new TrieNode[26]; // 26 for each char lowercase a-z
4        public int index = -1; // index of shortest matching word
5    }
6
7    public int[] StringIndices(string[] wordsContainer, string[] wordsQuery) {
8        int[] sIndicies = new int[wordsQuery.Length];
9        TrieNode root = new TrieNode();
10
11        // build the Trie and store the index of the shortest matching word
12        for (int i = 0; i < wordsContainer.Length; i++)
13        {
14            string reversed = Reverse(wordsContainer[i]);
15            Insert(root, reversed, i, wordsContainer);
16        }
17
18        // search for the best word
19        for (int i = 0; i < wordsQuery.Length; i++)
20        {
21            string query = Reverse(wordsQuery[i]);
22            sIndicies[i] = Search(root, query);
23        }
24
25        return sIndicies;
26    }
27
28    // updates the best index of a TrieNode (smallest in length, called in order of occurance of words) 
29    void Update(TrieNode node, int idx, string[] words)
30    {
31        if (node.index == -1 || words[idx].Length < words[node.index].Length)
32        {
33            node.index = idx;
34        }
35    }
36
37    // insertion of word into Trie 
38    void Insert(TrieNode node, string word, int index, string[] words)
39    {
40        Update(node, index, words);
41
42        foreach (char c in word)
43        {
44            int idx = c - 'a';
45
46            if (node.next[idx] == null)
47            {
48                node.next[idx] = new TrieNode();
49            }
50
51            node = node.next[idx];
52
53            Update(node, index, words);
54        }
55    }
56
57    // returns the 'best' index from the Trie
58    int Search(TrieNode node, string query)
59    {
60        int best = node.index;
61
62        foreach (char c in query)
63        {
64            int idx = c - 'a';
65
66            if (node.next[idx] == null) break;
67
68            node = node.next[idx];
69            best = node.index;
70        }
71
72        return best;
73    }
74
75    string Reverse(string s) {
76        char[] chars = s.ToCharArray();
77        Array.Reverse(chars);
78        return new string(chars);
79    }
80}