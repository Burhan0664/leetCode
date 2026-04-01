using System.Numerics;

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int[] freq = new int[nums.Length+1];
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            freq[nums[i]]++;
        }
        for (int i = 0; i < freq.Length; i++) 
        {
            if (freq[i]==0)
            {
                result = i;
            }
        }
        return result;
    }
    //nums 100% beats
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int sum = n * (n + 1) / 2;
        int news = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            news += nums[i];
        }
        return sum - news;
    }
    public int MissingNumber(int[] nums)
    {
     
        int xor = nums.Length;

        for (int i = 0; i < nums.Length; i++)
        {
            xor ^= i ^ nums[i];
        }

        return xor;
    }
}
