// Last updated: 28/05/2025, 13:16:42
public class Solution {
    public string AddStrings(string num1, string num2) {
        StringBuilder sb = new StringBuilder();
        int maxLength = Math.Max(num1.Length, num2.Length);
        int carry = 0;

        for (int i = 1; i <= maxLength; i++)
        {
            int sum = carry;
            sum += (i <= num1.Length) ? num1[num1.Length - i] - '0' : 0;
            sum += (i <= num2.Length) ? num2[num2.Length - i] - '0' : 0;
            carry = sum / 10;
            sb.Insert(0, sum % 10);
        }

        if (carry > 0)
        {
            sb.Insert(0, carry);
        }

        return sb.ToString();
    }
}