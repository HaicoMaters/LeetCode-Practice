// Last updated: 28/05/2025, 13:15:41
public class Solution {
    public string DefangIPaddr(string address) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < address.Length; i++)
        {
            if (address[i] == '.')
                sb.Append("[.]");
            else
                sb.Append(address[i]);
        }
        return sb.ToString();
    }
}