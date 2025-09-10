// Last updated: 10/09/2025, 11:59:08
public class Solution {
    public int MinimumTeachings(int n, int[][] languages, int[][] friendships) {
        int m = languages.Length;

        List<HashSet<int>> userLanguages = new List<HashSet<int>>();

        foreach (int[] userLangs in languages)
        {
            HashSet<int> set = new HashSet<int>(userLangs);
            userLanguages.Add(set);
        }

        HashSet<int> badComUsers = new HashSet<int>();
        
        foreach (int[] f in friendships)
        {
            int u = f[0] - 1;
            int v = f[1] - 1;

            HashSet<int> languagesU = userLanguages[u];
            HashSet<int> languagesV = userLanguages[v];

            bool canCom = false;
            foreach (int language in languagesU)
            {
                if (languagesV.Contains(language))
                {
                    canCom = true;
                    break;
                }
            }

            if (!canCom)
            {
                badComUsers.Add(u);
                badComUsers.Add(v);
            }
        }

        if (badComUsers.Count == 0) return 0;

        int minTeach = int.MaxValue;

        for (int lang = 1; lang <= n; lang++)
        {
            int count = 0;
            
            foreach (int user in badComUsers)
            {
                if (userLanguages[user].Contains(lang))
                {
                    count++;
                }
            }

            int toTeach = badComUsers.Count - count;
            minTeach = Math.Min(minTeach, toTeach);
        }

        return minTeach;
    }
}