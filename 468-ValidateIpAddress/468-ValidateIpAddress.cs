// Last updated: 28/05/2025, 13:16:33
public class Solution {

    static readonly HashSet<char> allowedCharsIPv6= new HashSet<char>
    {'0','1','2','3','4','5','6','7','8','9','a','b','c','d','e','f','A','B','C','D','E','F'};

    public string ValidIPAddress(string queryIP) {

        if (ValidIPv4Address(queryIP)) return "IPv4";
        if (ValidIPv6Address(queryIP)) return "IPv6";
        return "Neither";

    }

    public bool ValidIPv4Address(string IP) {
        string[] parts = IP.Split('.');

        if (parts.Length != 4) return false; // Must have exactly 4 parts

        foreach (string part in parts) {
            if (part.Length == 0 || part.Length > 3) return false; // Each part must be 1-3 digits
            
            if (part[0] == '0' && part.Length != 1) return false; // No leading zeros 

            if (!int.TryParse(part, out int num)) return false; // Must be a valid integer

            if (num < 0 || num > 255) return false; // Must be in range 0-255
        }
        
        return true;
    }

    public bool ValidIPv6Address(string IP){
        string[] parts = IP.Split(':');

        if (parts.Length != 8) return false;

        foreach (string part in parts){
            if (part.Length == 0 || part.Length > 4) return false; // Each part must be 1-4 digits

            foreach (char c in part){
                if (!allowedCharsIPv6.Contains(c)) return false;
            }
        }
        
        return true;
    }
}