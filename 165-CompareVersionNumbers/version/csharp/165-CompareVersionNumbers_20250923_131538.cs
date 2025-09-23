// Last updated: 23/09/2025, 13:15:38
public class Solution {
    public int CompareVersion(string version1, string version2) {
        int idx1 = 0;
        int idx2 = 0;
        int len1 = version1.Length;
        int len2 = version2.Length;

        while(idx1 < len1 || idx2 < len2)
        {
            int num1 = 0;
            while (idx1 < len1 && version1[idx1] != '.')
            {
                num1 = num1 * 10 + (version1[idx1] - '0');
                idx1++;
            }
            idx1++;

            int num2 = 0;
            while (idx2 < len2 && version2[idx2] != '.')
            {
                num2 = num2 * 10 + (version2[idx2] - '0');
                idx2++;
            }
            idx2++;

            if (num1 > num2) return 1;
            if (num1 < num2) return -1;
            // The part of the version label is the same otherwise check after the next '.' to compare version
        }

        return 0;
    }
}