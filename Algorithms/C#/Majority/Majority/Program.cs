public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int indicator = nums.Length / 2;
        int a = 0;
        int result = 0;
        for (int i = 0; i < nums.Length; i++) 
        {
            foreach (int x in nums)
            {
                if (x == nums[i])
                {
                    a++;
                }
            }
            if (indicator<a) 
            {
                result = nums[i];
                break;
            }
            a = 0;
        }
        return result;
    }
}