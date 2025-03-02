public class Solution {
    public double[] ConvertTemperature(double celsius) {
        double[] temp = new double[2];
        temp[0] = celsius + 273.15;
        temp[1] = celsius * 1.80 + 32.00;
        return temp;
    }
}