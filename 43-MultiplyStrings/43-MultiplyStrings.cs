public class Solution {
    public string Multiply(string num1, string num2) 
    {
        if (num1 == "0" || num2 == "0") return "0";

        int len1 = num1.Length; 
        int len2 = num2.Length;
        int[] result = new int[len1 + len2];

        for (int i = len1 - 1; i >= 0; i--) { // Start with multiplication from end of string/int array
            for (int j = len2 - 1; j >= 0; j--) {
                int mul = (num1[i] - '0') * (num2[j] - '0'); // Use Unicode to Get int Values Fast
                int sum = mul + result[i + j + 1]; // Add the current carry on from last sum

                result[i + j + 1] = sum % 10; // Store the unit Column
                result[i + j] += sum / 10; // Store the 10s column in front of the unit
            }
        }

        StringBuilder sb = new StringBuilder();
        foreach (int num in result) {
            if (!(sb.Length == 0 && num == 0)) // Skip leading zeros
                sb.Append(num);
        }

        return sb.ToString();
    }
}