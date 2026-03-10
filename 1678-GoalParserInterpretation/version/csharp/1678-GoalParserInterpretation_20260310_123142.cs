// Last updated: 10/03/2026, 12:31:42
1public class Solution {
2    public string Interpret(string command) {
3        StringBuilder interpretation = new StringBuilder();
4
5        for (int i = 0; i < command.Length; i++)
6        {
7
8            if (command[i] == 'G')
9            {
10                interpretation.Append('G');
11                continue;
12            }
13
14            if (command[i] != '(') continue;
15
16            if(command[i+1] == 'a')
17            {
18                interpretation.Append("al");
19                i += 2;
20            }
21            else
22            {
23                interpretation.Append('o');
24                i += 1;
25            }
26        }
27
28        return interpretation.ToString();
29    }
30}