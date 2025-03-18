public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> occurences = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (!occurences.ContainsKey(num))
            {
                occurences[num] = 0;
            }
            occurences[num]++;
        }

        HashSet<int> numOccur = new HashSet<int>();

        foreach (int num in occurences.Values){
            if (numOccur.Contains(num)) return false;
            numOccur.Add(num);
        }
        
        return true;
    }
}