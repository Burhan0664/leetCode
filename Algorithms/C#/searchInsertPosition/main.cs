public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int result = 0;
        if (nums.Length>1)
        {
            for (int i = 0; i < nums.Length-1; i++)
        {
            if (target>nums[i]&&target<nums[i+1])
            {
                result =i+1;
            }
            else if(target>nums[nums.Length-1]){
                result=nums.Length;
            }
            else if(nums[i]==target){
                result = i;
            }
            else if(nums[i+1]==target){
                result=i+1;
            }
        }
        }
        else if(nums.Length==1)
        {
           if (nums[0]>target)
           {
            result =0;
           }
           else if(target>nums[0])
           {
            result=1;
           }
        }
     
        
            
        
        return result;
    }
}