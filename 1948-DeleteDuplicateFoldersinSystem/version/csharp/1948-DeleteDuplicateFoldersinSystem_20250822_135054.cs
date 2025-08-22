// Last updated: 22/08/2025, 13:50:54
public class Solution {
    public class TrieNode{
        public string Name;
        public Dictionary<string, TrieNode> Children = new Dictionary<string, TrieNode>();
        public string Serial = ""; // unique identifier for finding duplicate folders
        public bool IsDeleted = false;

        public TrieNode(string name)
        {
            Name = name;
        }
    }

    public string Serialize(TrieNode node) // use as a form of hashing to help find duplicate folders
    {
        if (node.Children.Count == 0) return "";

        List<string> parts = new List<string>();

        foreach (TrieNode child in node.Children.Values)
        {
            string childSerial = Serialize(child);
            parts.Add(child.Name + "(" + childSerial + ")");
        }

        parts.Sort(); // order doesn't matter just want to be consistent across nodes 
        string serial = string.Join("", parts);
        node.Serial = serial;

        if (!serialMap.ContainsKey(serial))
        {
            serialMap[serial] = new List<TrieNode>();
        }
        serialMap[serial].Add(node);

        return serial;
    }

    public List<IList<string>> GetRemainingPaths(TrieNode node, List<string> path, List<IList<string>> paths) // Gets all non deleted paths as a List in the structure asked by the problem
    {
        foreach (TrieNode child in node.Children.Values)
        {
            if (child.IsDeleted) continue;

            path.Add(child.Name);
            paths.Add(new List<string>(path));
            GetRemainingPaths(child, path, paths);
            path.RemoveAt(path.Count - 1);
        }

        return paths;
    }

    TrieNode root = new TrieNode("");
    Dictionary<string, List<TrieNode>> serialMap = new Dictionary<string, List<TrieNode>>();

    public IList<IList<string>> DeleteDuplicateFolder(IList<IList<string>> paths) {
        foreach (var path in paths) // Build the Trie
        {
            TrieNode current = root;
            foreach (string folder in path)
            {
                if (!current.Children.ContainsKey(folder))
                {
                    current.Children[folder] = new TrieNode(folder);
                }
                current = current.Children[folder];
            }
        }

        Serialize(root);

        foreach (var entry in serialMap) // delete duplicate files using the serial map
        {
            if (entry.Value.Count > 1)
            {
                foreach (var node in entry.Value)
                {
                    node.IsDeleted = true;
                }
            }
        }

        return GetRemainingPaths(root, new List<string>(), new List<IList<string>>());
    }
}