// Last updated: 28/05/2025, 13:16:23
using System.Security.Cryptography;
public class Codec {

    Dictionary<string, string> hashLookup = new Dictionary<string, string>(); // Store the hash and original value

    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        // Using sha256 to hash the url and then store in the lookup with the real url
        using (SHA256 sha256 = SHA256.Create()) {
        byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(longUrl));
        string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

        if(!hashLookup.ContainsKey(hash)){
            hashLookup[hash] = longUrl;
        }

        return hash;
        }
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        if (hashLookup.ContainsKey(shortUrl)){
            return hashLookup[shortUrl];
        }

        return "";
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));