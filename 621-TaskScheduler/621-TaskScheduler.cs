public class Solution {
    public int LeastInterval(char[] tasks, int n) {

        Dictionary<char, int> labelCount = new Dictionary<char, int>();

        foreach (char task in tasks){
            if (!labelCount.ContainsKey(task)){
                labelCount[task] = 1;
            }
            else{
                labelCount[task]++;
            }
        }
        
        int maxFrequency = labelCount.Values.Max();
        int maxFrequencyTasks = labelCount.Values.Count(v => v == maxFrequency); // Number of tasks with highest frequency
        int minIntervals = (maxFrequency - 1) * (n + 1) + maxFrequencyTasks; // Start with most frequent task and see how long is required
        // to wait for that task to have enough cycles (e.g. n = 2 max freq = 3 (letter is A) A, _, _, A, _, _, A) is how many cycles is 
        // required then for multiple with the same frequency that means just do that letter straight after so will be + how many max frequency
        // tasks total

        return Math.Max(minIntervals, tasks.Length); // Larger of minimum intervals and total tasks to be completed
        

    }
}