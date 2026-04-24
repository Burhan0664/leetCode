public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int last = m + n - 1;
        int mind = m - 1;
        int nind = n - 1;

        while (nind>=0)
        {
            if (mind>=0 && nums1[mind] > nums2[nind])
            {
                nums1[last--] = nums1[mind--];
            }
            else
            {
                nums1[last--] = nums2[nind--];
            }
        }


    }
}