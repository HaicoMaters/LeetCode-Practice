public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        var frequencies = new Dictionary<string, int>();

        foreach(string word in words){
            if(frequencies.ContainsKey(word)){
                frequencies[word]++;
            } 
            else{
                frequencies.Add(word, 1);
            }
        }

        // Use a custom comparer
        var pq = new PriorityQueue<string, (int, string)>(Comparer<(int, string)>.Create(
            (a, b) => a.Item1 == b.Item1 ? string.Compare(a.Item2, b.Item2) : b.Item1 - a.Item1
        ));

        foreach (var kvp in frequencies) {
            pq.Enqueue(kvp.Key, (kvp.Value, kvp.Key));
        }

        List<string> topK = new List<string>();

        for (int i = 0; i < k; i++){
            topK.Add(pq.Dequeue());
        }

        return topK;
    }
}