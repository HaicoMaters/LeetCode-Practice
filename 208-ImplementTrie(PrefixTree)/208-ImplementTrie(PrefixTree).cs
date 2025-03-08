public class TrieNode{
    
    public Dictionary<char, TrieNode> children;
    public bool isEndOfWord {get; set;}

    public TrieNode(){
        children = new Dictionary<char, TrieNode>();
        isEndOfWord = false;
    }
}

public class Trie {

    TrieNode root;

    public Trie() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode currentNode = root;

        foreach (char c in word){

            // Add new node if does not exist
            if (!currentNode.children.ContainsKey(c)){
                currentNode.children[c] = new TrieNode();
            }

            // Move onto next node
            currentNode = currentNode.children[c];
        }

        // Make node end of word
        currentNode.isEndOfWord = true;
    }
    
    public bool Search(string word) {
        TrieNode currentNode = root;
        
        foreach (char c in word){

            // If node does not exist no word exists
            if (!currentNode.children.ContainsKey(c)){
                return false;
            }

            // Move onto next node
            currentNode = currentNode.children[c];
        }

        return currentNode.isEndOfWord;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode currentNode = root;
        
        foreach (char c in prefix){

            // If node does not exist no word with prefix exists
            if (!currentNode.children.ContainsKey(c)){
                return false;
            }

            // Move onto next node
            currentNode = currentNode.children[c];
        }
        return true;
    }

}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */