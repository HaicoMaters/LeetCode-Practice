// Last updated: 14/07/2026, 10:11:17
1public class SubrectangleQueries {
2    int[][] rect;
3
4    public SubrectangleQueries(int[][] rectangle) {
5        rect = rectangle;
6    }
7    
8    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue) {
9        for (int row = row1; row <= row2; row++)
10        {
11            for (int col = col1; col <= col2; col++)
12            {
13                rect[row][col] = newValue;
14            }
15        }
16    }
17    
18    public int GetValue(int row, int col) {
19        return rect[row][col];    
20    }
21}
22
23/**
24 * Your SubrectangleQueries object will be instantiated and called as such:
25 * SubrectangleQueries obj = new SubrectangleQueries(rectangle);
26 * obj.UpdateSubrectangle(row1,col1,row2,col2,newValue);
27 * int param_2 = obj.GetValue(row,col);
28 */