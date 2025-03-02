public class Solution {
    public int CalPoints(string[] operations) {
        List<int> record = new List<int>();

        for(int i = 0; i < operations.Length; i++)
        {
            int size = record.Count;
            switch (operations[i])
            {
                case "+":
                    record.Add(record[size - 1] + record[size - 2]);
                    break;
                case "D":
                    record.Add(record[size -1] * 2);
                    break;
                case "C":
                    record.RemoveAt(size - 1);
                    break;
                default:
                    record.Add(int.Parse(operations[i]));
                    break;
            }
        }

        int sum = 0;
        foreach (int i in record)
        {
            sum += i;
        }
        return sum;
    }
}