// Last updated: 28/05/2025, 13:17:50
public class Node {
    public Dictionary<char, Node> children;
    public bool isEndOfWord {get; set;}

    public Node(){
        isEndOfWord = false;
        children = new Dictionary<char, Node>();
    }
}

public class WordDictionary {

    public Node root;

    public WordDictionary() {
        root = new Node();    
    }
    
    public void AddWord(string word) {
        Node current = root;

        foreach (char c in word){
            if (!current.children.ContainsKey(c)){
                current.children.Add(c, new Node());
            }
            current = current.children[c];
        }

        current.isEndOfWord = true;
    }
    
    public bool Search(string word) {
        return DFSForWord(root, word, 0);
    }
    
    public bool DFSForWord(Node current, string word, int index) {

        if (index == word.Length) {
            return current.isEndOfWord;
        }

        if (word[index] == '.') {
            // Search each child using DFS until a match is found
            foreach (Node n in current.children.Values) {
                bool found = DFSForWord(n, word, index + 1);
                if (found) return true;
            }
        } 
        else {
            // Regular character, continue the search for that character
            if (current.children.ContainsKey(word[index])) {
                return DFSForWord(current.children[word[index]], word, index + 1);
            }
        }

        return false;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */