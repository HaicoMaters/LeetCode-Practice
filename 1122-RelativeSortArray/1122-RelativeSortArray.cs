public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        Dictionary<int, int> frequencies = new Dictionary<int, int>();

        for (int i = 0; i < arr1.Length; i++){
            if (frequencies.ContainsKey(arr1[i])){
                frequencies[arr1[i]]++;
            }
            else{
                frequencies[arr1[i]] = 1;
            }
        }

        int arr1Index = 0; // index in arr1

        // Do all the numbers only in arr2
        for (int i = 0; i < arr2.Length; i++){
            while (frequencies[arr2[i]] > 0)
            {
                arr1[arr1Index] = arr2[i];
                arr1Index++;
                frequencies[arr2[i]]--;
            }
        }

        var sortedKVPs = frequencies.OrderBy(kvp => kvp.Key);
        
        foreach (var kvp in sortedKVPs){
            for (int i = 0; i < kvp.Value; i++)
            {
                arr1[arr1Index] = kvp.Key;
                arr1Index++;
            }
        }

        return arr1;
    }
}