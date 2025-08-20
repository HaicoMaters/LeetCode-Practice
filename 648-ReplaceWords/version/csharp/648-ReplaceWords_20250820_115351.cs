// Last updated: 20/08/2025, 11:53:51
public class Solution { // Trie Version
    public class TrieNode{
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public string word = null;
    }

    public class Trie{
        private TrieNode root;

        public Trie(){
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode node = root;
            foreach (char c in word)
            {
                if (!node.children.ContainsKey(c))
                {
                    node.children[c] = new TrieNode();
                }
                node = node.children[c];
            }
            node.word = word;
        }

        public string SearchPrefix(string word)
        {
            TrieNode node = root;
            foreach (char c in word)
            {
                if(!node.children.ContainsKey(c))
                {
                    break;
                }

                node = node.children[c];
                
                if (node.word != null)
                {
                    return node.word;
                }
            }

            return word;
        }
    }

    public string ReplaceWords(IList<string> dictionary, string sentence) {
        Trie trie = new Trie();

        foreach (string root in dictionary)
        {
            trie.Insert(root);
        }

        string[] words = sentence.Split(' ');
        
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = trie.SearchPrefix(words[i]);
        }

        return string.Join(" ", words);
    }
}