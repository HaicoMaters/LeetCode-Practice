public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> answer = new List<string>();

        for (int i = 1; i <= n; i++){
            string str = "";
            if (i % 3 == 0) str = str + "Fizz";
            if (i % 5 == 0) str = str + "Buzz";
            if (str == "") str = i.ToString();
            answer.Add(str);
        }

        return answer;
    }
}