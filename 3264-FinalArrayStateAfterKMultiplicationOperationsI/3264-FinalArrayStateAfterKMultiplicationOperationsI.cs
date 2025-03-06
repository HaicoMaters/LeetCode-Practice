public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {

        var operations = new PriorityQueue<int, (int, int)>(); // Tuple to compare index after sum (index , (sum, index))

        for(int i = 0; i < nums.Length; i++){
            operations.Enqueue(i, (nums[i], i));
        }

        while(k > 0){
            int index = operations.Dequeue();
            nums[index] = nums[index]*multiplier;
            operations.Enqueue(index, (nums[index], index));
            k--;
        }

        return nums;
    }
}