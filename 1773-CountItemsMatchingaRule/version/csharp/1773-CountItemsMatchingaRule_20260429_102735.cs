// Last updated: 29/04/2026, 10:27:35
1public class Solution {
2    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
3        int matches = 0;
4
5        foreach (var item in items)
6        {
7            string type = item[0];
8            string colour = item[1];
9            string name = item[2];
10
11            if (ruleKey == "type")
12            {
13                if (type == ruleValue) matches++;
14            }
15            if (ruleKey == "color")
16            {
17                if (colour == ruleValue) matches++;
18            }
19            if (ruleKey == "name")
20            {
21                if (name == ruleValue) matches++;
22            }
23        }
24
25        return matches;
26    }
27}