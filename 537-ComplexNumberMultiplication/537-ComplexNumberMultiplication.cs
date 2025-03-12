public class Solution {
    public string ComplexNumberMultiply(string num1, string num2) {

        string[] parts1 = num1.Split('+');
        string[] parts2 = num2.Split('+');
        parts1[1] = parts1[1].Replace("i", "");
        parts2[1] = parts2[1].Replace("i", "");

        int num1Real = int.Parse(parts1[0]);
        int num1Imaginary = int.Parse(parts1[1]);
        int num2Real = int.Parse(parts2[0]);
        int num2Imaginary = int.Parse(parts2[1]);

        int real = (num1Real * num2Real) - (num1Imaginary * num2Imaginary); // - as i^2 is -1
        int imaginary = (num1Real * num2Imaginary) + (num2Real * num1Imaginary);

        return $"{real}+{imaginary}i";
    }
}