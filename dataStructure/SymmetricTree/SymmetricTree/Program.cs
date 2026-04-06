public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null) return true;
        return IsSame(root.left, root.right);
    }

    public bool IsSame(TreeNode leftroot, TreeNode rightroot)
    {
        if (leftroot == null && rightroot == null)
            return true;

        if (leftroot == null || rightroot == null)
            return false;

        if (leftroot.val != rightroot.val)
            return false;

        return IsSame(leftroot.left, rightroot.right) &&
               IsSame(leftroot.right, rightroot.left);
    }
}