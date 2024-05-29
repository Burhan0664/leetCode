public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int newIndex = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            nums[newIndex] = nums[i]; 
            newIndex++; // 
        }
    }

    return newIndex; 
    }
}