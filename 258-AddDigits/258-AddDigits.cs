public class Solution {
    public int AddDigits(int num) {
        // Look at solutions for explanation of O(1) way of doing it
        if(num==0)return num;
        return (num % 9) == 0 ? 9 : num % 9;
    }
}