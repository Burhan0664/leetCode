public class Solution {
    public int RemoveDuplicates(int[] nums) {
          int length = nums.Length;
    if (length <= 1)
        return length;

    int currentIndex = 1;
    for (int i = 1; i < length; i++)
    {
        if (nums[i] != nums[i - 1])
        {
            nums[currentIndex] = nums[i];
            currentIndex++;
        }
    }

    return currentIndex;

    }
}