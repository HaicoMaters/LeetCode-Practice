public class Solution {
    public bool IsPerfectSquare(int num) {
        if (num == 1) return true;

        long start = 1;
        long end = num;

        while (start <= end){
            long mid = start + (end - start) / 2;
            long squared = mid * mid;
            if (squared == num) return true;
            if (squared < num)
            {
                start = mid + 1;
            }
            else{
                end = mid - 1;
            }
        }

        return false;
    }
}