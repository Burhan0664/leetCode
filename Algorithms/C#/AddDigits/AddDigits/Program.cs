public class Solution
{
    public int AddDigits(int num)
    {
        string result = num.ToString();
        int sum = 0;
        while (result.Length > 1) 
        {
            sum = 0;
            foreach (char c in result) 
            {
                sum += c - '0';
            }
            result = sum.ToString();
        }
        return Convert.ToInt32(result);
    }
}