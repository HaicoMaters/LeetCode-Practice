public class Solution {
    public string AddBinary(string a, string b) {
        bool carryOn = false;
        int aLength = a.Length;
        int bLength = b.Length;
        StringBuilder binary = new StringBuilder();
        int n = (aLength > bLength) ? aLength : bLength;
        for (int i = 0; i < n; i++)
        {
            // Get chars avoiding passing bounds
            char numA = (i >= aLength) ? '0' : a[aLength - 1 - i];
            char numB = (i >= bLength) ? '0' : b[bLength - 1 - i];

            if (carryOn) // Deal with the carryOn
            {
                if(numA == '1') numA = '0';
                else
                {
                    numA = '1';
                    carryOn = false;
                }
            }

            if (numA == '1' && numB == '1')
            {
                binary.Insert(0, '0');
                carryOn = true;
            }
            else if (numA == '1' || numB == '1') binary.Insert(0, '1');
            else binary.Insert(0, '0');
        }

        if (carryOn)
        {
            binary.Insert(0, '1');
        }

        return binary.ToString();
    }
}